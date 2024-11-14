using AutoMapper;
using BookStoreApplication.Dtos;
using BookStoreCore.Entities;

namespace BookStoreAPI.Util
{
    public class MappingProfile: Profile
    {

        public MappingProfile()
        {
            CreateMap<Book, BookDTO>();
            CreateMap<BookDTO, Book>();
            CreateMap<Author, AuthorDTO>();
            CreateMap<AuthorDTO, Author>();
        }

    }
}
