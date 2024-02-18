using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSatis.Entities
{
    public class Slider:IEntity
    {
        public int Id { get; set; }
        [StringLength(150),Display(Name ="Başlık")]
        public string? Baslık { get; set; }
        [StringLength(500),Display(Name = "Açıklama")]
        public string? Acıklama { get; set; }
        [StringLength(100)]
        public string? Resim { get; set; }
        [StringLength(100)]
        public string? Link { get; set; }
    }
}
