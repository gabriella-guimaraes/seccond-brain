using AutoMapper;
using second_brain.API.ViewModel;
using second_brain.Domain.Entities;

namespace second_brain.API.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() 
        { 
            CreateMap<User, UserViewModel>();
            CreateMap<Reminder, ReminderViewModel>();
        }
    }
}
