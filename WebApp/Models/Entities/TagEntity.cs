﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Entities
{
    public class TagEntity
    {
        [Key]
        public int Id{ get; set; }
        public string TagName { get; set; } = null!;


        public ICollection<ProductTagEntity> Tags { get; set;} = new HashSet<ProductTagEntity>();
    }
}
