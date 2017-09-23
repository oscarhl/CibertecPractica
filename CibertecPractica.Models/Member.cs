using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CibertecPractica.Models
{
    public class Member
    {
        [ExplicitKey]
        public int member_no { get; set; }        
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string middleinitial { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state_prov { get; set; }
        public string country { get; set; }
        public string mail_code { get; set; }
        public string phone_no { get; set; }
        public DateTime issue_dt { get; set; }
        public DateTime expr_dt { get; set; }
        public decimal prev_balance { get; set; }
        public decimal curr_balance { get; set; }
        public string member_code { get; set; }
    }
}
