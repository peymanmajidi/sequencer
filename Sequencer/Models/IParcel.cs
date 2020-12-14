using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sequencer.Models
{
    public interface IParcel
    {
        Button Button { get; set; }
        Gate Gate { get; set; }

        void Shift();
        void Up();
        void Down();


    }
}
