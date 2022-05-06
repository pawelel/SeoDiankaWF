using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeoDiankaWF;

public partial class Form1 : Form
{
    private readonly ListViewColumnSorter _lvwColumnSorter;
    public Form1()
    {
        InitializeComponent();
        // Create an instance of a ListView column sorter and assign it
        // to the ListView control.
        _lvwColumnSorter = new ListViewColumnSorter();
        LvSentence.ListViewItemSorter = _lvwColumnSorter;
        LvStatistics.ListViewItemSorter = _lvwColumnSorter;
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {

        RtbWorkingArea.Invoke((MethodInvoker)delegate
          {
              RtbWorkingArea.SelectionStart = 0;
              RtbWorkingArea.SelectAll();
              RtbWorkingArea.SelectionBackColor = Color.White;
              RtbWorkingArea.SelectionColor = Color.Black;

              if (string.IsNullOrWhiteSpace(TbSearch.Text))
              {
                  return;
              }
              string[] _words = TbSearch.Text.Split(new char[] { '.', ';', ':', ',' });
              LblWait.Invoke((MethodInvoker)async delegate
               {
                   await Task.FromResult(LblWait.Text = "Proszę czekać, aplikacja wykonuje zadanie.");
               });

              foreach (string _word in _words)
              {
                  if (string.IsNullOrWhiteSpace(_word))
                  {
                      continue;
                  }
                  string _pattern = @"(\W|^)" + _word + @"(\W|$)";
                  Regex _regex = new(_pattern, RegexOptions.IgnoreCase);
                  MatchCollection _matches = _regex.Matches(RtbWorkingArea.Text);
                  foreach (Match _match in _matches)
                  {
                      RtbWorkingArea.Invoke((MethodInvoker)delegate
                       {
                           RtbWorkingArea.SelectionStart = _match.Index;
                           RtbWorkingArea.SelectionLength = _match.Length;
                           RtbWorkingArea.SelectionBackColor = Color.Purple;
                           RtbWorkingArea.SelectionColor = Color.White;
                       });
                  }
              }

              LblWait.Text = string.Empty;
          });
    }


    private void BtnCount_Click(object sender, EventArgs e)
    {
        LvStatistics.Items.Clear();
        LvSentence.Items.Clear();
        foreach (var item in GetWordCountList())
        {
            string[] row = { item.Item1, item.Item2.ToString(), item.Item3 + "%" };
            ListViewItem listViewItem = new(row);
            LvStatistics.Items.Add(listViewItem);
        }
        foreach (var item in GetSentenceCountList(RtbWorkingArea.Text))
        {
            string[] row = { item.Item1, item.Item2.ToString(), item.Item3.ToString(), item.Item4 + "%" };
            ListViewItem listViewItem = new(row);
            LvSentence.Items.Add(listViewItem);
        }
    }

    static List<string> WordList(string text)
    {
        string[] source = Regex.Split(text, @"\W", RegexOptions.IgnorePatternWhitespace);
        List<string> words = new();
        foreach (string word in source)
        {
           if (string.IsNullOrWhiteSpace(word))
           {
               continue;
           }
              words.Add(word);
        }
        return words;
    }

    private static List<string> SentenceList(string text)
    {
        string[] source = Regex.Split(text, @"(?<=[\?|\!|\.\.\.|\.])", RegexOptions.IgnorePatternWhitespace);
        List<string> sentences = new();
        foreach (string sentence in source)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                continue;
            }
           
            // check if sentence contains letters or numbers
            if (!Regex.IsMatch(sentence, @"^[a-zA-Z0-9]+(\?|\!|\.\.\.|\.)$"))
            {
                var sentenceTrimmed = sentence.Trim();
                sentences.Add(sentenceTrimmed);
            }
        }
        return sentences;
    }
    // get sentence, sentence index, count words in sentence, count sentence percentage in all words
    private static List<Tuple<string, int, int, double>> GetSentenceCountList(string text)
    {
        List<Tuple<string, int, int, double>> sentenceCountList = new();

        // count all words int text ignore case
        List<string> words = WordList(text);
        int wordCount = words.Count;
        // split text to sentences
        List<string> sentences = SentenceList(text);
        int sentenceCount = sentences.Count;
        // count words in each sentence
        for (int i = 0; i < sentences.Count; i++)
        {
            int sentenceWordCount = 0;
     
            foreach (string word in WordList(sentences[i]))
            {
                if (string.IsNullOrWhiteSpace(word))
                {
                    continue;
                }
                sentenceWordCount++;
            }
            // count sentence percentage in all words
            double sentencePercentage = Math.Round((double)sentenceWordCount / wordCount * 100,2);
            sentenceCountList.Add(new(sentences[i], i, sentenceWordCount, sentencePercentage));
            sentenceCount++;
        }
        return sentenceCountList;
    }



    static List<(string, int, double)> DistinctStringCount(string text)
    {
        List<string> words = WordList(text);
        List<(string, int, double)> tuple = new();
        foreach (string word in words)
        {
            int count = words.Count(w => w.Equals(word, StringComparison.InvariantCultureIgnoreCase));
            double percent = Math.Round((double)count * 100 / words.Count, 2);
            if (!tuple.Any(p => p.Item1.Equals(word, StringComparison.InvariantCultureIgnoreCase)))
            {
                tuple.Add((word, count, percent));
            }
        }
        return tuple.OrderByDescending(p => p.Item2).ToList();
    }
    private List<(string, int, double)> GetWordCountList()
    {
        return DistinctStringCount(RtbWorkingArea.Text);
    }

    private void LvStatistics_MouseClick(object sender, MouseEventArgs e)
    {
        string word = LvStatistics.SelectedItems[0].SubItems[0].Text;
        TbSearch.Text = word;
    }

    private void BtnClearAll_Click(object sender, EventArgs e)
    {
        TbSearch.Text = string.Empty;
        LvStatistics.Items.Clear();
        RtbWorkingArea.Text = string.Empty;
        LvSentence.Items.Clear();
    }

    private void RtbWorkingArea_TextChanged(object sender, EventArgs e)
    {
        RtbWorkingArea.SelectionFont = new Font(RtbWorkingArea.SelectionFont.FontFamily, 14.0F);
        LblCountChars.Text = RtbWorkingArea.Text.Length.ToString();
        LblCountWords.Text = SentenceList(RtbWorkingArea.Text).Count.ToString();
    }

    private void LvSentence_MouseClick(object sender, MouseEventArgs e)
    {
        string word = LvSentence.SelectedItems[0].SubItems[0].Text;
        TbSearch.Text = word;
    }

    private void LvSentence_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        // Determine if clicked column is already the column that is being sorted.
        if (e.Column == _lvwColumnSorter.SortColumn)
        {
            // Reverse the current sort direction for this column.
            if (_lvwColumnSorter.Order == SortOrder.Ascending)
            {
                _lvwColumnSorter.Order = SortOrder.Descending;
            }
            else
            {
                _lvwColumnSorter.Order = SortOrder.Ascending;
            }
        }
        else
        {
            // Set the column number that is to be sorted; default to ascending.
            _lvwColumnSorter.SortColumn = e.Column;
            _lvwColumnSorter.Order = SortOrder.Ascending;
        }

        // Perform the sort with these new sort options.
        this.LvSentence.Sort();
    }

    private void LvStatistics_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        // Determine if clicked column is already the column that is being sorted.
        if (e.Column == _lvwColumnSorter.SortColumn)
        {
            // Reverse the current sort direction for this column.
            if (_lvwColumnSorter.Order == SortOrder.Ascending)
            {
                _lvwColumnSorter.Order = SortOrder.Descending;
            }
            else
            {
                _lvwColumnSorter.Order = SortOrder.Ascending;
            }
        }
        else
        {
            // Set the column number that is to be sorted; default to ascending.
            _lvwColumnSorter.SortColumn = e.Column;
            _lvwColumnSorter.Order = SortOrder.Ascending;
        }

        // Perform the sort with these new sort options.
        LvStatistics.Sort();
    }


   
    
}
