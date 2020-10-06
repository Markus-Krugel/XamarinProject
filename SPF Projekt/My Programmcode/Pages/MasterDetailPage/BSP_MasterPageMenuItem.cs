using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinBeispiele
{

    public class BSP_MasterPageMenuItem
    {
        public BSP_MasterPageMenuItem()
        {
            TargetType = typeof(BSP_MasterPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public ImageSource Image { get; set; }

        public Type TargetType { get; set; }
    }
}