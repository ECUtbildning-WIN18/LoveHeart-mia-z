using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class RMenu : Draw
    {
        User LoggedInUser { get; set; }

        public RMenu(User loggedInUser)
        {

        }

        public override void DrawBox()
        {
            base.DrawBox();

        }
    }
}
