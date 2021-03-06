﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProArch.FieldOrbit.Models;

namespace ProArch.FieldOrbit.DataContracts.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDeviceRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceModel"></param>
        /// <returns></returns>
        bool AddDeviceInfo(Content deviceModel);

        /// <summary>
        /// Update device information
        /// </summary>
        /// <param name="deviceModel"></param>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        bool UpdateDeviceInfo(Content deviceModel, int DeviceID);

        /// <summary>
        /// Get Device by device id
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        Device GetDeviceByID(int DeviceID);

        /// <summary>
        /// Get all devices
        /// </summary>
        /// <returns></returns>
        List<Content> GetAllDevices();

        /// <summary>
        /// Get expert by device id
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        string GetExpert(int DeviceID);
    }
}
