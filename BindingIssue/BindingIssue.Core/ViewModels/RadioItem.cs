using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingIssue.Core.ViewModels
{
    public class RadioItem
    {
        public string Caption { get; set; }

        public override bool Equals(object obj)
        {
            var rb = obj as RadioItem;
            if (rb == null) return false;
            return rb.Caption == this.Caption;
        }
        public override int GetHashCode()
        {
            return Caption.GetHashCode();
        }
    }
}
