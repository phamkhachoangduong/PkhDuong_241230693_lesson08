using System;
using System.Collections.Generic;

namespace PkhDuong_241230693_lesson08.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
