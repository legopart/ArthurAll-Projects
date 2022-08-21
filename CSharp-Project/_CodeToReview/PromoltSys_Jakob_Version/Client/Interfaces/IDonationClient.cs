﻿using Client.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface IDonationClient
    {
        [Post("/api/donations")]
        Task CreateDonation([Body] DonationModel Donation);

      
        [Get("/api/donations/{id}")]
        Task<DonationModel> GetDonation(string id);
        [Get("/api/donations")]
        Task<List<DonationModel>> GetDonations();
        [Get("/api/donations/filter/{id}")]
        Task<List<DonationModel>> GetDonations(string id);
        [Put("/api/donations/{id}")]
        Task UpdateDonation(string id, [Body] DonationModel updatedDonation);

    }
}
