using System.Text.RegularExpressions;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace SeoDiankaWF;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
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
                  Regex _regex = new Regex(_pattern, RegexOptions.IgnoreCase);
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
        List<string> words = new();
        List<string> sentences = SentenceList(text);
        foreach (string sentence in sentences)
        {
            words = WordList(sentence);
            int sentenceCount = words.Count;
            int sentenceCountInAllWords = 0;
            foreach (string word in words)
            {
                sentenceCountInAllWords += WordList(text).Count(x => x == word);
            }
            double sentenceCountPercentage = Math.Round((double)words.Count/ sentenceCountInAllWords * 100,2);
            sentenceCountList.Add(new(sentence, sentences.IndexOf(sentence), sentenceCount, sentenceCountPercentage));
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

    }
}
