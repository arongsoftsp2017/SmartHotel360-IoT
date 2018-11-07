﻿using System;
using SmartHotel.IoT.Provisioning.Common.Models.DigitalTwins;

namespace SmartHotel.IoT.Provisioning.Common.Models
{
	public class PropertyKeyDescription
	{
		public const string DeviceIdPrefixName = "DeviceIdPrefix";

		public string name { get; set; }
		public string primitiveDataType { get; set; }
		public string description { get; set; }
		public string validationData { get; set; }
		public string min { get; set; }
		public string max { get; set; }

		public PropertyKey ToDigitalTwins(Guid spaceId)
		{
			return new PropertyKey
			{
				Name = name,
				SpaceId = spaceId.ToString(),
				PrimitiveDataType = primitiveDataType,
				Description = description,
				ValidationData = validationData,
				Min = min,
				Max = max
			};
		}
	}
}
