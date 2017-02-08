using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel;

namespace MembershipApp.Entities
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(1024)]
        public string Url { get; set; }

        [MaxLength(1024)]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Will only allow admin users to submit HTML into the database
        /// Only admin users will be able to create additional admin users
        /// </summary>
        [AllowHtml]
        public string HTML { get; set; }

        /// <summary>
        /// Excluded from Database mapping, will allow for "calculation"/return of first
        /// 50 characters of the HTML property.  If there are no characters or less than
        /// 50 characters, then the unmodified content of the HTML property should be
        /// returned
        /// </summary>
        [NotMapped]
        public string HTMLShort {
            get {
                return HTML == null || HTML.Length < 50 ? HTML : HTML.Substring(0, 50);
                }
        }

        [DefaultValue(0)]
        [DisplayName("Wait Days")]
        public int WaitDays { get; set; }

        [DisplayName("Is Free")]
        public bool IsFree { get; set; }

        public int ItemTypeId { get; set; }
        [DisplayName("Item Types")]
        public ICollection<ItemType> ItemTypes { get; set; }

        public int PartId { get; set; }
        public ICollection<Part> Parts { get; set; }

        public int SectionId { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}