using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LazyPeopleAPI.Datas;

public class Project
{
    public int ID { get; set; }

    [DisplayName("Name")]
    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(200)]
    public string Description { get; set; }

    [StringLength(500)]
    public string Content { get; set; }

    public string Url { get; set; }

    public DateTime? Date { get; set; }

    public int Sort { get; set; }

    public bool Del { get; set; }

    public DateTime Created { get; set; }


}