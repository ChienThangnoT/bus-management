using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagement
{
    public class Util
    {
        public TimeSpan? GetTime(string txtTime)
        {
            var time = TimeSpan.MinValue;
            if (!TimeSpan.TryParse(txtTime, out time))
            {
                ShowNoiceBox($"Thời gian '{txtTime}' không hợp lệ!");
                return null;
            }
            return time;
        }
        public void ShowNoiceBox(string msg)
        {
            MessageBox.Show(msg, "Thông Báo", MessageBoxButtons.OK);
        }
    }
}
