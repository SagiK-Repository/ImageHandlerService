using Core.Domain;
using Core.Domain.Entity;
using Core.Domain.Loader;
using Core.Domain.Service;
using Core.Domain.Transfer;
using Core.Domain.Transform;
using Microsoft.EntityFrameworkCore;

namespace Feature.DataBase.Context;

public class ImageHandlerDBContext : DbContext
{
    public ImageHandlerDBContext(DbContextOptions<ImageHandlerDBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region One to Many
        modelBuilder.Entity<LoaderInfo>()
            .HasOne<ServiceInfo>(s => s.ServiceInfo)
            .WithMany(r => r.LoaderInfos)
            .HasForeignKey(s => s.Id);

        modelBuilder.Entity<TransformInfo>()
            .HasOne<ServiceInfo>(s => s.ServiceInfo)
            .WithMany(r => r.TransformInfos)
            .HasForeignKey(s => s.Id);

        modelBuilder.Entity<TransferInfo>()
            .HasOne<ServiceInfo>(s => s.ServiceInfo)
            .WithMany(r => r.TransferInfos)
            .HasForeignKey(s => s.Id);

        modelBuilder.Entity<Image>()
            .HasOne<ImageGroup>(s => s.ImageGroup)
            .WithMany(r => r.Images)
            .HasForeignKey(s => s.Id);
        #endregion

        #region Many to Many
        modelBuilder.Entity<ImageGroupLoaderInfo>()
            .HasKey(g => new { g.ImageGroupId, g.LoaderId });

        modelBuilder.Entity<ImageGroupTransferInfo>()
            .HasKey(g => new { g.ImageGroupId, g.TransferId });

        modelBuilder.Entity<ImageGroupTransformInfo>()
            .HasKey(g => new { g.ImageGroupId, g.TransformId });
        #endregion
    }

    public DbSet<ServiceInfo> Services { get; set; }
    public DbSet<LoaderInfo> LoaderInfos { get; set; }
    public DbSet<TransformInfo> TransformInfos { get; set; }
    public DbSet<TransferInfo> TransferInfos { get; set; }
    public DbSet<ImageGroup> ImageGroups { get; set; }
}
