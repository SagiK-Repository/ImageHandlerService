using Core.Domain;
using Core.Domain.Entity;
using Core.Domain.Loader;
using Core.Domain.Service;
using Core.Domain.Transfer;
using Core.Domain.Transform;
using Core.Domain.ValueObject;
using ImageHandlerService.Core.Domain.ValueObject;
using Microsoft.EntityFrameworkCore;

namespace Feature.DataBase.Context;

public class ImageHandlerDBContext : DbContext
{
    public ImageHandlerDBContext(DbContextOptions<ImageHandlerDBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region ID Mapping
        modelBuilder.Entity<ServiceInfo>()
            .Property(e => e.Id)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<LoaderInfo>()
            .Property(e => e.Id)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<TransformInfo>()
            .Property(e => e.Id)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<TransferInfo>()
            .Property(e => e.Id)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<ImageGroup>()
            .Property(e => e.Id)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<Image>()
            .Property(e => e.Id)
            .HasConversion(id => id.Value, value => new ID(value));

        modelBuilder.Entity<LoaderInfo>()
            .Property(e => e.LookDir)
            .HasConversion(v => v.directoryPath, v => new Dir(v));
        modelBuilder.Entity<LoaderInfo>()
            .Property(e => e.ModeDir)
            .HasConversion(v => v.directoryPath, v => new Dir(v));
        modelBuilder.Entity<TransferInfo>()
            .Property(e => e.SendDir)
            .HasConversion(v => v.directoryPath, v => new Dir(v));
        modelBuilder.Entity<TransformInfo>()
            .Property(e => e.FileType)
            .HasConversion(v => v.type, v => new FileType(v));
        modelBuilder.Entity<ImageGroup>()
            .Property(e => e.Name)
            .HasConversion(v => v.name, v => new Name(v));
        modelBuilder.Entity<Image>()
            .Property(e => e.Name)
            .HasConversion(v => v.name, v => new Name(v));
        modelBuilder.Entity<Image>()
            .Property(e => e.Type)
            .HasConversion(v => v.type, v => new FileType(v));
        modelBuilder.Entity<Image>()
            .Property(e => e.Size)
            .HasConversion(v => v.Bytes, v => new FileSize(v));


        modelBuilder.Entity<ImageGroupLoaderInfo>()
            .Property(e => e.ImageGroupId)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<ImageGroupLoaderInfo>()
            .Property(e => e.LoaderId)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<ImageGroupTransferInfo>()
            .Property(e => e.ImageGroupId)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<ImageGroupTransferInfo>()
            .Property(e => e.TransferId)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<ImageGroupTransformInfo>()
            .Property(e => e.ImageGroupId)
            .HasConversion(id => id.Value, value => new ID(value));
        modelBuilder.Entity<ImageGroupTransformInfo>()
            .Property(e => e.TransformId)
            .HasConversion(id => id.Value, value => new ID(value));
        #endregion

        #region Entity ID
        modelBuilder.Entity<ServiceInfo>().HasKey(si => si.Id);
        modelBuilder.Entity<LoaderInfo>().HasKey(li => li.Id);
        modelBuilder.Entity<TransformInfo>().HasKey(ti => ti.Id);
        modelBuilder.Entity<TransferInfo>().HasKey(ti => ti.Id);
        modelBuilder.Entity<ImageGroup>().HasKey(ig => ig.Id);
        modelBuilder.Entity<Image>().HasKey(i => i.Id);
        #endregion

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
        modelBuilder.Entity<ImageGroupLoaderInfo>().HasKey(g => new { g.ImageGroupId, g.LoaderId });

        modelBuilder.Entity<ImageGroupTransferInfo>().HasKey(g => new { g.ImageGroupId, g.TransferId });

        modelBuilder.Entity<ImageGroupTransformInfo>().HasKey(e => new { e.ImageGroupId, e.TransformId });
        #endregion
    }

    public DbSet<ServiceInfo> Services { get; set; }
    public DbSet<LoaderInfo> LoaderInfos { get; set; }
    public DbSet<TransformInfo> TransformInfos { get; set; }
    public DbSet<TransferInfo> TransferInfos { get; set; }
    public DbSet<ImageGroup> ImageGroups { get; set; }

    public DbSet<ImageGroupLoaderInfo> ImageGroupLoaderInfos { get; set; }
    public DbSet<ImageGroupTransferInfo> ImageGroupTransferInfos { get; set; }
    public DbSet<ImageGroupTransformInfo> ImageGroupTransformInfos { get; set; }
}
