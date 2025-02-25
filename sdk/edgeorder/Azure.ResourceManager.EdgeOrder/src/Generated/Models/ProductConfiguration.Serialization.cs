// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductConfiguration
    {
        internal static ProductConfiguration DeserializeProductConfiguration(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<ProductDescription> description = default;
            Optional<IReadOnlyList<ImageInformation>> imageInformation = default;
            Optional<CostInformation> costInformation = default;
            Optional<AvailabilityInformation> availabilityInformation = default;
            Optional<HierarchyInformation> hierarchyInformation = default;
            Optional<IReadOnlyList<FilterableProperty>> filterableProperties = default;
            Optional<IReadOnlyList<ProductSpecification>> specifications = default;
            Optional<ProductDimensions> dimensions = default;
            Optional<IReadOnlyList<ChildConfigurationType>> childConfigurationTypes = default;
            Optional<IReadOnlyList<GroupedChildConfigurations>> groupedChildConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            description = ProductDescription.DeserializeProductDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("imageInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ImageInformation> array = new List<ImageInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.ImageInformation.DeserializeImageInformation(item));
                            }
                            imageInformation = array;
                            continue;
                        }
                        if (property0.NameEquals("costInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            costInformation = CostInformation.DeserializeCostInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("availabilityInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            availabilityInformation = AvailabilityInformation.DeserializeAvailabilityInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hierarchyInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hierarchyInformation = HierarchyInformation.DeserializeHierarchyInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filterableProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FilterableProperty> array = new List<FilterableProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FilterableProperty.DeserializeFilterableProperty(item));
                            }
                            filterableProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("specifications"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ProductSpecification> array = new List<ProductSpecification>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProductSpecification.DeserializeProductSpecification(item));
                            }
                            specifications = array;
                            continue;
                        }
                        if (property0.NameEquals("dimensions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dimensions = ProductDimensions.DeserializeProductDimensions(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("childConfigurationTypes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ChildConfigurationType> array = new List<ChildConfigurationType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ChildConfigurationType(item.GetString()));
                            }
                            childConfigurationTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("groupedChildConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<GroupedChildConfigurations> array = new List<GroupedChildConfigurations>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.GroupedChildConfigurations.DeserializeGroupedChildConfigurations(item));
                            }
                            groupedChildConfigurations = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProductConfiguration(displayName.Value, description.Value, Optional.ToList(imageInformation), costInformation.Value, availabilityInformation.Value, hierarchyInformation.Value, Optional.ToList(filterableProperties), Optional.ToList(specifications), dimensions.Value, Optional.ToList(childConfigurationTypes), Optional.ToList(groupedChildConfigurations));
        }
    }
}
