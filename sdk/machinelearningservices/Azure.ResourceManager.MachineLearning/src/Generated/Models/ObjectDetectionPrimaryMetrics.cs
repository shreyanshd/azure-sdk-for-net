// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Primary metrics for Image ObjectDetection task. </summary>
    public readonly partial struct ObjectDetectionPrimaryMetrics : IEquatable<ObjectDetectionPrimaryMetrics>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ObjectDetectionPrimaryMetrics"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ObjectDetectionPrimaryMetrics(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MeanAveragePrecisionValue = "MeanAveragePrecision";

        /// <summary>
        /// Mean Average Precision (MAP) is the average of AP (Average Precision).
        /// AP is calculated for each class and averaged to get the MAP.
        /// </summary>
        public static ObjectDetectionPrimaryMetrics MeanAveragePrecision { get; } = new ObjectDetectionPrimaryMetrics(MeanAveragePrecisionValue);
        /// <summary> Determines if two <see cref="ObjectDetectionPrimaryMetrics"/> values are the same. </summary>
        public static bool operator ==(ObjectDetectionPrimaryMetrics left, ObjectDetectionPrimaryMetrics right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ObjectDetectionPrimaryMetrics"/> values are not the same. </summary>
        public static bool operator !=(ObjectDetectionPrimaryMetrics left, ObjectDetectionPrimaryMetrics right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ObjectDetectionPrimaryMetrics"/>. </summary>
        public static implicit operator ObjectDetectionPrimaryMetrics(string value) => new ObjectDetectionPrimaryMetrics(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ObjectDetectionPrimaryMetrics other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ObjectDetectionPrimaryMetrics other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
