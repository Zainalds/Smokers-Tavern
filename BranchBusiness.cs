﻿using SmokersTavernStore.Business.Interfaces;
using SmokersTavernStore.Data.Model;
using SmokersTavernStore.Model;
using SmokersTavernStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Business.Business_Logic
{
    public class BranchBusiness : IBranchBusiness
    {
        public void Insert(BranchViewModel model)
        {
            Guid Id = Guid.NewGuid();
            string ID = Id.ToString();

            using (var repo = new BranchRepository())
            {
                repo.Insert(new Branch
                {
                    ClientId = ID,
                    BranchName = model.BranchName,
                    BranchManager = model.BranchManager,
                    BranchAddress = model.BranchAddress,
                    BranchContactNumber = model.BranchContactNumber,
                    BranchEmail = model.BranchEmail
                });
            }
        }


        public IEnumerable<BranchViewModel> GetAll()
        {
            var branches = new List<BranchViewModel>();

            using (var repository = new BranchRepository())
            {
                branches = repository.GetAll().Select(model => new BranchViewModel
                {
                    BranchId = model.BranchId,
                    ClientId = model.ClientId,
                    BranchName = model.BranchName,
                    BranchManager = model.BranchManager,
                    BranchAddress = model.BranchAddress,
                    BranchContactNumber = model.BranchContactNumber,
                    BranchEmail = model.BranchEmail

                }).ToList();
            }
            return branches;
        }
        public void Update(BranchViewModel model)
        {
            using (var repository = new BranchRepository())
            {
                var c = new Branch();
                c = repository.GetById(model.BranchId);
                if (c != null)
                {
                    c.BranchId = model.BranchId;
                    c.BranchName = model.BranchName;
                    c.BranchManager = model.BranchManager;
                    c.BranchAddress = model.BranchAddress;
                    c.BranchContactNumber = model.BranchContactNumber;
                    c.BranchEmail = model.BranchEmail;
                    repository.Update(c);
                }
            }
        }
        public BranchViewModel GetByBranchId(int id)
        {
            using (var repository = new BranchRepository())
            {
                return repository.Find(x => x.BranchId == id).Select(model => new BranchViewModel
                {
                    BranchId = model.BranchId,
                    BranchName = model.BranchName,
                    BranchManager = model.BranchManager,
                    BranchAddress = model.BranchAddress,
                    BranchContactNumber = model.BranchContactNumber,
                    BranchEmail = model.BranchEmail,
                }).FirstOrDefault();
            }
        }
    }
}
