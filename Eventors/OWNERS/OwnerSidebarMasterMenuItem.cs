using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventors.OWNERS
{
    public class OwnerSidebarMasterMenuItem
    {
        public OwnerSidebarMasterMenuItem()
        {
            TargetType = typeof(OwnerSidebarMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}