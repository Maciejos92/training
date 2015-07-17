﻿using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.PiotrekJ
{
    public class PiotrekJBankTransfer : BankTransfer
    {
        public string SourceAccount { get; set; }
        public string DestinationAccount { get; set; }
        public string SourceUserName { get; set; }
        public string DestinationUserName { get; set; }
        public double Cash { get; set; }
        public string Title { get; set; }
        public string SendDate { get; set; }
    }
}