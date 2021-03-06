using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SampleMVCApp.Models
{
    public class Person
    {
        // PersionIdをレコードの主キーとする

        public int PersonId { get; set; }

        [Required(ErrorMessage = "必須項目です")]
        [Index(IsUnique = true)]
        [StringLength(256)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage ="メールアドレスが必要です")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Required(ErrorMessage = "必須項目です")]
        [Range(0, 200, ErrorMessage = "必須項目です")]
        [DataType(DataType.Text)]
        public int Age { get; set; }

        [Display(Name="投稿")]
        public ICollection<Message> Messages { get; set; }
    }
}
