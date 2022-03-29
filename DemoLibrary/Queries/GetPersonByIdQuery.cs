using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;

    //yukarıdaki yazım ile aşağıdaki uzun yazım aslında aynı. Yani yukarıdaki kısa yazım da kullanım kolaylığı açısından tercih edilebilir.

    //public class GetPersonByIdQueryClass : IRequest<PersonModel>
    //{
    //    public int Id { get; set; }
    //    public GetPersonByIdQueryClass(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
