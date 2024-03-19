using System.ComponentModel.DataAnnotations;

namespace form_MNJ.Models;

public class Candidate
    [Key] public int Id { get; set; }
    //[Key] public Guid Id { get; set; }

    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    [Required][MaxLength(150)]public string? Given Name { get; set; }
    public string? Surname { get; set; }
    public int Social Security Number { get; set; }
    public string? Sex { get; set; }
    //public decimal Price { get; set; }
    public string? Adress { get; set; }
    public int Phone { get; set; }
    // [NotMapped] Propiedad string Resumne {get;set}

}