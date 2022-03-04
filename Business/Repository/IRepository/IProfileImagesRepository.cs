﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IProfileImagesRepository
    {

        public Task<int> CreateProfileImage(ProfileImageDTO image);
    }
}
