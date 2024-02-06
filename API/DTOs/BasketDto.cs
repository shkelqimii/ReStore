using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.DTOs;

public class BasketDto
{
    public int Id { get; set; }
    public string BuyerId { get; set; }
    public List<BasketItemDto> Items { get; set; }

    public static implicit operator BasketDto(ActionResult<BasketDto> v)
    {
        throw new NotImplementedException();
    }
}