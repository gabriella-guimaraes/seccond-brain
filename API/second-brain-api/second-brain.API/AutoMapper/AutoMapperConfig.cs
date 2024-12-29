using AutoMapper;

namespace second_brain.API.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.AddProfile<DomainToViewModelMappingProfile>();
                config.AddProfile<ViewModelToDomainMappingProfile>();
            });

            var mapper = new Mapper(configuration);
        }
    }
}
