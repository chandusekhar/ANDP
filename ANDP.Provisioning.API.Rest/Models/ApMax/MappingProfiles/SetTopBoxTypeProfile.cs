﻿using Common.Lib.Mapping;

namespace ANDP.Provisioning.API.Rest.Models.ApMax.MappingProfiles
{
    public class SetTopBoxTypeProfile : CommonMappingProfile
    {
        protected override void Configure()
        {
            CreateMap<Common.IPTVServiceV3.SetTopBoxType, SetTopBoxType>()
                .ForMember(dest => dest.AllowedStreamCount, opt => opt.MapFrom(src => src.AllowedStreamCount))
                .ForMember(dest => dest.Authorized, opt => opt.MapFrom(src => src.Authorized))
                .ForMember(dest => dest.BandwidthGroup, opt => opt.MapFrom(src => src.BandwidthGroup))
                .ForMember(dest => dest.FipsCountyCode, opt => opt.MapFrom(src => src.FIPSCountyCode))
                .ForMember(dest => dest.FipsStateCode, opt => opt.MapFrom(src => src.FIPSStateCode))
                .ForMember(dest => dest.InstallDate, opt => opt.MapFrom(src => src.InstallDate))
                .ForMember(dest => dest.IpAddress, opt => opt.MapFrom(src => src.IPAddress))
                .ForMember(dest => dest.MacAddress, opt => opt.MapFrom(src => src.MACAddress))
                .ForMember(dest => dest.MaxBandwidthKbps, opt => opt.MapFrom(src => src.MaxBandwidthKbps))
                .ForMember(dest => dest.MaxSimultaneousRecordings, opt => opt.MapFrom(src => src.MaxSimultaneousRecordings))
                .ForMember(dest => dest.RfChannel, opt => opt.MapFrom(src => src.RFChannel))
                .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                .ForMember(dest => dest.StbModel, opt => opt.MapFrom(src => src.STBModel))
                .ForMember(dest => dest.WholeHomeGroup, opt => opt.MapFrom(src => src.WholeHomeGroup))
                .ForMember(dest => dest.HdmiMode, opt => opt.Ignore())
                .ForMember(dest => dest.IRBand, opt => opt.MapFrom(src => src.IRBand))
                .ForMember(dest => dest.InactivityDetuneOverride, opt => opt.MapFrom(src => src.InactivityDetuneOverride))
                .ForMember(dest => dest.STBName, opt => opt.MapFrom(src => src.STBName))
                .ForMember(dest => dest.WiringType, opt => opt.Ignore())
                ;

            CreateMap<Common.IPTVServiceV7.SetTopBoxType, SetTopBoxType>()
                .ForMember(dest => dest.AllowedStreamCount, opt => opt.MapFrom(src => src.AllowedStreamCount))
                .ForMember(dest => dest.Authorized, opt => opt.MapFrom(src => src.Authorized))
                .ForMember(dest => dest.BandwidthGroup, opt => opt.MapFrom(src => src.BandwidthGroup))
                .ForMember(dest => dest.FipsCountyCode, opt => opt.MapFrom(src => src.FIPSCountyCode))
                .ForMember(dest => dest.FipsStateCode, opt => opt.MapFrom(src => src.FIPSStateCode))
                .ForMember(dest => dest.InstallDate, opt => opt.MapFrom(src => src.InstallDate))
                .ForMember(dest => dest.IpAddress, opt => opt.MapFrom(src => src.IPAddress))
                .ForMember(dest => dest.MacAddress, opt => opt.MapFrom(src => src.MACAddress))
                .ForMember(dest => dest.MaxBandwidthKbps, opt => opt.MapFrom(src => src.MaxBandwidthKbps))
                .ForMember(dest => dest.MaxSimultaneousRecordings, opt => opt.MapFrom(src => src.MaxSimultaneousRecordings))
                .ForMember(dest => dest.RfChannel, opt => opt.MapFrom(src => src.RFChannel))
                .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                .ForMember(dest => dest.StbModel, opt => opt.MapFrom(src => src.STBModel))
                .ForMember(dest => dest.WholeHomeGroup, opt => opt.MapFrom(src => src.WholeHomeGroup))
                .ForMember(dest => dest.HdmiMode, opt => opt.Ignore())
                .ForMember(dest => dest.IRBand, opt => opt.MapFrom(src => src.IRBand))
                .ForMember(dest => dest.InactivityDetuneOverride, opt => opt.MapFrom(src => src.InactivityDetuneOverride))
                .ForMember(dest => dest.STBName, opt => opt.MapFrom(src => src.STBName))
                .ForMember(dest => dest.WiringType, opt => opt.Ignore())
                ;

            CreateMap<SetTopBoxType, Common.IPTVServiceV3.SetTopBoxType>()
                .ForMember(dest => dest.AllowedStreamCount, opt => opt.MapFrom(src => src.AllowedStreamCount))
                .ForMember(dest => dest.Authorized, opt => opt.MapFrom(src => src.Authorized))
                .ForMember(dest => dest.BandwidthGroup, opt => opt.MapFrom(src => src.BandwidthGroup))
                .ForMember(dest => dest.FIPSCountyCode, opt => opt.MapFrom(src => src.FipsCountyCode))
                .ForMember(dest => dest.FIPSStateCode, opt => opt.MapFrom(src => src.FipsStateCode))
                .ForMember(dest => dest.InstallDate, opt => opt.MapFrom(src => src.InstallDate))
                .ForMember(dest => dest.IPAddress, opt => opt.MapFrom(src => src.IpAddress))
                .ForMember(dest => dest.MACAddress, opt => opt.MapFrom(src => src.MacAddress))
                .ForMember(dest => dest.MaxBandwidthKbps, opt => opt.MapFrom(src => src.MaxBandwidthKbps))
                .ForMember(dest => dest.MaxSimultaneousRecordings, opt => opt.MapFrom(src => src.MaxSimultaneousRecordings))
                .ForMember(dest => dest.RFChannel, opt => opt.MapFrom(src => src.RfChannel))
                .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                .ForMember(dest => dest.STBModel, opt => opt.MapFrom(src => src.StbModel))
                .ForMember(dest => dest.WholeHomeGroup, opt => opt.MapFrom(src => src.WholeHomeGroup))
                .ForMember(dest => dest.ConnectorType, opt => opt.Ignore())
                .ForMember(dest => dest.DisplayMode, opt => opt.Ignore())
                .ForMember(dest => dest.DisplayResolution, opt => opt.Ignore())
                .ForMember(dest => dest.ExcludedPackagesList, opt => opt.Ignore())
                .ForMember(dest => dest.MiddlewareType, opt => opt.Ignore())
                .ForMember(dest => dest.RecordingAllowed, opt => opt.Ignore())
                .ForMember(dest => dest.STBLocation, opt => opt.Ignore())
                .ForMember(dest => dest.TrialGroupID, opt => opt.Ignore())
                .ForMember(dest => dest.ExtensionData, opt => opt.Ignore())
                .ForMember(dest => dest.TvType, opt => opt.Ignore())
                ;

            CreateMap<SetTopBoxType, Common.IPTVServiceV7.SetTopBoxType>()
                .ForMember(dest => dest.AllowedStreamCount, opt => opt.MapFrom(src => src.AllowedStreamCount))
                .ForMember(dest => dest.Authorized, opt => opt.MapFrom(src => src.Authorized))
                .ForMember(dest => dest.BandwidthGroup, opt => opt.MapFrom(src => src.BandwidthGroup))
                .ForMember(dest => dest.FIPSCountyCode, opt => opt.MapFrom(src => src.FipsCountyCode))
                .ForMember(dest => dest.FIPSStateCode, opt => opt.MapFrom(src => src.FipsStateCode))
                .ForMember(dest => dest.InstallDate, opt => opt.MapFrom(src => src.InstallDate))
                .ForMember(dest => dest.IPAddress, opt => opt.MapFrom(src => src.IpAddress))
                .ForMember(dest => dest.MACAddress, opt => opt.MapFrom(src => src.MacAddress))
                .ForMember(dest => dest.MaxBandwidthKbps, opt => opt.MapFrom(src => src.MaxBandwidthKbps))
                .ForMember(dest => dest.MaxSimultaneousRecordings, opt => opt.MapFrom(src => src.MaxSimultaneousRecordings))
                .ForMember(dest => dest.RFChannel, opt => opt.MapFrom(src => src.RfChannel))
                .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                .ForMember(dest => dest.STBModel, opt => opt.MapFrom(src => src.StbModel))
                .ForMember(dest => dest.WholeHomeGroup, opt => opt.MapFrom(src => src.WholeHomeGroup))
                .ForMember(dest => dest.ConnectorType, opt => opt.Ignore())
                .ForMember(dest => dest.DisplayMode, opt => opt.Ignore())
                .ForMember(dest => dest.DisplayResolution, opt => opt.Ignore())
                .ForMember(dest => dest.ExcludedPackagesList, opt => opt.Ignore())
                .ForMember(dest => dest.MiddlewareType, opt => opt.Ignore())
                .ForMember(dest => dest.RecordingAllowed, opt => opt.Ignore())
                .ForMember(dest => dest.STBLocation, opt => opt.Ignore())
                .ForMember(dest => dest.TrialGroupID, opt => opt.Ignore())
                .ForMember(dest => dest.ExtensionData, opt => opt.Ignore())
                .ForMember(dest => dest.TvType, opt => opt.Ignore())
                ;
        }
    }
}