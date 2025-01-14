﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommerceApiSDK.Models;
using CommerceApiSDK.Models.Parameters;
using CommerceApiSDK.Models.Results;

namespace CommerceApiSDK.Services.Interfaces
{
    public interface IVmiLocationsService
    {
        Task<GetVmiLocationResult> GetVmiLocations(VmiLocationQueryParameters parameters = null);
        Task<GetVmiBinResult> GetVmiBins(VmiBinQueryParameters parameters = null);
        Task<GetVmiCountResult> GetBinCounts(VmiCountQueryParameters parameters = null);
        Task<GetVmiNoteResult> GetVmiLocationNotes(
            BaseVmiLocationQueryParameters parameters = null
        );

        Task<VmiLocationModel> GetVmiLocation(VmiLocationDetailParameters parameters = null);
        Task<VmiBinModel> GetVmiBin(VmiBinDetailParameters parameters = null);
        Task<VmiCountModel> GetBinCount(VmiCountDetailParameters parameters = null);
        Task<VmiNoteModel> GetVmiBinNote(VmiNoteDetailParameters parameters = null);

        Task<ServiceResponse<VmiLocationModel>> SaveVmiLocation(VmiLocationModel model);
        Task<ServiceResponse<VmiBinModel>> SaveVmiBin(Guid vmiLocationId, VmiBinModel model);
        Task<ServiceResponse<VmiCountModel>> SaveBinCount(
            Guid vmiLocationId,
            Guid vmiBinId,
            VmiCountModel model
        );
        Task<ServiceResponse<VmiNoteModel>> SaveVmiBinNote(
            Guid vmiLocationId,
            Guid vmiBinId,
            VmiNoteModel model
        );

        Task<ServiceResponse<VmiLocationModel>> DeleteVmiLocation(Guid vmiLocationId);
        Task<ServiceResponse<VmiBinModel>> DeleteVmiBin(Guid vmiLocationId, Guid vmiBinId);
        Task<ServiceResponse<VmiCountModel>> DeleteBinCount(
            Guid vmiLocationId,
            Guid vmiBinId,
            Guid vmiCountId
        );
        Task<ServiceResponse<VmiNoteModel>> DeleteVmiBinNote(
            Guid vmiLocationId,
            Guid vmiBinId,
            Guid vmiNoteId
        );

        Task<GetProductCollectionResult> GetProducts(
            VmiLocationProductParameters parameters = null
        );
        Task<IList<AutocompleteProduct>> GetAutocompleteProducts(
            VmiLocationProductParameters parameters = null
        );
    }
}
