using System.Text.RegularExpressions;
using System.Windows.Forms;

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


    private void LvStatistics_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void BtnCount_Click(object sender, EventArgs e)
    {
        LvStatistics.Items.Clear();
        foreach (var item in GetWordCountList())
        {
            string[] row = { item.Item1, item.Item2.ToString(), item.Item3.ToString()+"%" };
            ListViewItem listViewItem = new(row);
            LvStatistics.Items.Add(listViewItem);
        }
    }

    static List<string> WordListIgnoreCase(string text)
    {
        string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '}', '{' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> words = new();
        foreach (string word in source)
        {
            words.Add(word.ToLower());
        }
        return words;
    }
    static List<(string, int, double)> DistinctStringCount(string text)
    {
        List<string> words = WordListIgnoreCase(text);
        List<(string, int, double)> pairs = new();
        foreach (string word in words)
        {
            int count = words.Count(w => w == word);
            double percent = Math.Round((double) count*100 / words.Count, 2);
            if (!pairs.Any(p => p.Item1 == word))
            {
                pairs.Add((word, count, percent));
            }
        }
        return pairs.OrderByDescending(p => p.Item2).ToList();
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
    }

    private void RtbWorkingArea_TextChanged(object sender, EventArgs e)
    {
        RtbWorkingArea.SelectionFont = new Font(RtbWorkingArea.SelectionFont.FontFamily, 14.0F);
        LblCountChars.Text = RtbWorkingArea.Text.Length.ToString();
    }
}
