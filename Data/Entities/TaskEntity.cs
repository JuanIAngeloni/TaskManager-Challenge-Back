﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Manager.Entities
{
    public class TaskEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int taskId {  get; set; }
        [Required]
        [MaxLength(50)]
        public string title { get; set; } = string.Empty;
        [Required]
        [MaxLength(500)]
        public string description { get; set; } = string.Empty;
        [Required]
        public int priority {  get; set; }
        [Required]
        public bool isCompleted { get; set; } = false;
        [Required]
        public bool isDeleted { get; set; } = false;
        [Required]
        public DateTime createDate { get; set; }= DateTime.MinValue;
        [Required] 
        public DateTime updateDate { get;set; }= DateTime.MinValue;
        [Required]
        public int userId { get; set; }
        [Required]
        public int categoryId { get; set; }

        [ForeignKey("userId")]
        public virtual UserEntity user { get; set; }

        [ForeignKey("categoryId")]
        public virtual CategoryEntity category {  get; set; }
    }
}
