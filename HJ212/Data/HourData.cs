﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WQMStation.HJ212.Data
{
    public class HourData : HJ212Data
    {
        public HourData(DateTime datatime, VarItem[] vars)
            :base(datatime, vars)
        {
        }

        public override string DataString
        {
            get
            {
                var dataString = new StringBuilder();
                dataString.Append("DataTime=" + _datatime.ToString("yyyyMMddHHmmss") + ";");
                foreach (var v in _vars)
                {
                    dataString.Append(v.Code + "-Avg=" + v.Value.ToString(v.Format)
                                      + "," + v.Code + "-Flag=" + v.Flag + ";");
                }
                //remove the last ";"
                return dataString.ToString().Substring(0,dataString.Length - 1);
            }
        }

    }
}
