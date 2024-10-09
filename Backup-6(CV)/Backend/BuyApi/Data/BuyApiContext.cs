using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuyApi.Models;

namespace BuyApi.Data
{
    public class BuyApiContext : DbContext
    {
        public BuyApiContext(DbContextOptions<BuyApiContext> options)
            : base(options)
        {
        }

        public DbSet<BuyApi.Models.Buy> Buy { get; set; } = default!;
        public DbSet<BuyApi.Models.CouponCodes> CouponCodes { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for CouponCodes
            modelBuilder.Entity<CouponCodes>().HasData(
                new CouponCodes
                {
                    CouponId = 1,
                    Couponcode = "SHOPEASE200",
                    description = "Flat $200 off on minimum purchase of $599 and Free shipping.",
                    IsApplicable = true
                },
                new CouponCodes
                {
                    CouponId = 2,
                    Couponcode = "SUMMERSALE",
                    description = "Flat 25% off on summer collection.",
                    IsApplicable = false
                },
                new CouponCodes
                {
                    CouponId = 3,
                    Couponcode = "FREESHIP",
                    description = "Free shipping on orders over $499.",
                    IsApplicable = true
                },
                new CouponCodes
                {
                    CouponId = 4,
                    Couponcode = "SAVE100",
                    description = "Flat $100 off on your first purchase (min purchase of $299).",
                    IsApplicable = true
                },
                new CouponCodes
                {
                    CouponId = 5,
                    Couponcode = "BUY2GET50OFF",
                    description = "Buy 2, Get 50% Off on the 3rd One.",
                    IsApplicable = true
                }
            );
        }
    }
}
