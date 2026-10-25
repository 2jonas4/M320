namespace Assoziationen;
using System;
using System.Collections.Generic;
using System.Text;

{
    internal class Laus
{
    private Hund hund;
    public Laus(Hund hund)
    {
        this.hund = hund;
        this.hund.AddLaus(this);
    }

}