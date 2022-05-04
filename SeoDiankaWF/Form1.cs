using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SeoDiankaWF;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void BtnSearch_Click(object sender, EventArgs e)
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
        LblWait.Text = "Proszę czekać, aplikacja wykonuje zadanie.";
        await Task.Delay(1);
        foreach (string word in _words)
        {
            int startIndex = 0;
            while (startIndex < RtbWorkingArea.TextLength)
            {
                string pattern = @"(\W|^)" + word + @"(\W|$)";
                Regex rgx = new(pattern, RegexOptions.IgnoreCase);
                MatchCollection matches = rgx.Matches(RtbWorkingArea.Text);
                foreach (Match match in matches)
                {
                    RtbWorkingArea.SelectionStart = match.Index;
                    RtbWorkingArea.SelectionLength = match.Length;
                    RtbWorkingArea.SelectionBackColor = Color.Purple;
                    RtbWorkingArea.SelectionColor = Color.White;
                }
                startIndex += word.Length;
            

            }
        }
        LblWait.Text = string.Empty;
        
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
