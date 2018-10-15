using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BinaryHexConverter.Processor
{
    public class HistoryProcessor
    {
        public HistoryProcessor()
        {
            HistoryList = new ObservableCollection<string>();
        }


        //Propperties
        ObservableCollection<string> HistoryList { get; set; }


        //Methods
        internal IEnumerable SaveInput(string input)
        {
            HistoryList.Add(input);

            if(HistoryList.Count > 8)
            {
                HistoryList.RemoveAt(0);
            }

            return HistoryList;
        }
    }
}
