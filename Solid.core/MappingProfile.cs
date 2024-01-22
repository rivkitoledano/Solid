using AutoMapper;
using Solid.Core.Dto;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ClassDto, Class>().ReverseMap();
            CreateMap<EquipmentDto, Equipment>().ReverseMap();
            CreateMap<MemberDto, Member>().ReverseMap();
        }
    }
}
