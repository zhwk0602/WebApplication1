using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using WebApplication1.Domain;

namespace WebApplication1.Models
{
    public class Totall
    {
        private int s;
        private IPagedList<Customers> result;

        public Totall(int s, IPagedList<Customers> result)
        {
            this.s = s;
            this.result = result;
        }

        public int totall { get; set; }
    }
}