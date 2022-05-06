using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeoDiankaWF;
/// This class is an implementation of the 'IComparer' interface.
public class ListViewColumnSorter : IComparer
{
    public int SortColumn = 0;
    public SortOrder Order = SortOrder.Ascending;
    public int Compare(object x, object y) // IComparer Member
    {
        if (x is not ListViewItem)
            return (0);
        if (y is not ListViewItem)
            return (0);
        ListViewItem listviewX = (ListViewItem)x!;
        ListViewItem listviewY = (ListViewItem)y!;
       
        if (listviewX.ListView.Columns[SortColumn].Tag.ToString() == "Numeric")
        {
            float fl1 = float.Parse(listviewX.SubItems[SortColumn].Text.Replace("%", string.Empty));
            float fl2 = float.Parse(listviewY.SubItems[SortColumn].Text.Replace("%", string.Empty));
            return (Order == SortOrder.Ascending)?fl1.CompareTo(fl2):fl2.CompareTo(fl1);
        }
        else
        {
            string str1 = listviewX.SubItems[SortColumn].Text;
            string str2 = listviewY.SubItems[SortColumn].Text;
            return (Order == SortOrder.Ascending)?str1.CompareTo(str2):str2.CompareTo(str1);
        }
    }
}