using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ems.DataBase
{
    public class Word
    {
        public long Id { get; set; }
        public long UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get;set; }

        public string Value { get; set; }
        public string Translate { get; set; }
        public int Count { get; set; }
        public StateStudy State { get; set; }
        public bool IsFavorite { get; set; }
    }
}
