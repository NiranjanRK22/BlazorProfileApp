using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class ProfileImagesRepository : IProfileImagesRepository
    {
        private readonly ApplicationDbContext _db;

        private readonly IMapper _mapper;

        public ProfileImagesRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<int> CreateProfileImage(ProfileImageDTO imageDTO)
        {
            var image = _mapper.Map<ProfileImageDTO, ProfileImage>(imageDTO);
            await _db.ProfileImages.AddAsync(image);
            return await _db.SaveChangesAsync();
        }
    }
}
