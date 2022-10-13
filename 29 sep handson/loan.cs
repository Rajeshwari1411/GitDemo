namespace data
{
    using System;
    using System.Collections.Generic;

    public partial class loan
    {
        public int loanid { get; set; }
        public string loanname { get; set; }
        public string amount { get; set; }
        public string duration { get; set; }
        public string rateofinterest { get; set; }
    }
}
