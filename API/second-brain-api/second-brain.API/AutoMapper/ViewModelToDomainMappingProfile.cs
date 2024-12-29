using AutoMapper;
using second_brain.API.ViewModel;
using second_brain.Domain.Entities;

namespace second_brain.API.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() 
        {
            CreateMap<UserViewModel, User>();
            CreateMap<ReminderViewModel, Reminder>();
        }
    }
}
