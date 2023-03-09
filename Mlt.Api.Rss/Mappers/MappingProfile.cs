using AutoMapper;
using showRss = Mlt.Api.Rss.Dtos.ShowRssDto;
using nyaaRss = Mlt.Api.Rss.Dtos.NyaaRssDto;
using Mlt.Models.Rss;

namespace Mlt.Api.Rss.Mappers;

// ReSharper disable once UnusedType.Global
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        ShowRssProfiles();
        NyaaRssProfiles();
    }

    private void NyaaRssProfiles()
    {
        CreateMap<nyaaRss.RssDto, Models.Rss.Rss>()
           .ForPath(dto => dto.Items, opt => opt.MapFrom(src => src.Channel.Items));

        CreateMap<nyaaRss.ItemDto, RssItem>()
           .AfterMap((dto, rss) =>
                     {
                         rss.PublicationDate = DateTime.Parse(dto.PubDate);
                         rss.Identification = dto.Guid;
                     });
    }

    private void ShowRssProfiles()
    {
        CreateMap<showRss.RssDto, Models.Rss.Rss>().ForPath(dto => dto.Items, opt => opt.MapFrom(src => src.Channel.Items));

        CreateMap<showRss.ItemDto, RssItem>()
           .AfterMap((dto, rss) =>
                     {
                         rss.PublicationDate = DateTime.Parse(dto.PubDate);
                         rss.Identification = dto.Guid.Text;
                     });
    }
}