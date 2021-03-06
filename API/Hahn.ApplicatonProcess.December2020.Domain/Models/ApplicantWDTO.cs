﻿using System;
namespace Hahn.ApplicatonProcess.December2020.Domain.Models
{
    /// <summary>
    /// Data transfer object for writeonly requests
    /// </summary>

    public class ApplicantWDTO
    {
        /// <summary>
        ///     Name of the applicant.
        /// </summary>
        /// <example>Khaled</example>
        public string Name { get; set; }

        /// <summary>
        ///     Family name of the applicant.
        /// </summary>
        /// <example>Hussein</example>
        public string FamilyName { get; set; }

        /// <summary>
        ///     Address of the applicant.
        /// </summary>
        /// <example>Cairo, Egypt</example>
        public string Address { get; set; }

        /// <summary>
        ///     Country of origin of the applicant.
        /// </summary>
        /// <example>Egypt</example>
        public string CountryOforigin { get; set; }

        /// <summary>
        ///     Email address of the applicant.
        /// </summary>
        /// <example>me@example.com</example>
        public string EmailAddress { get; set; }

        /// <summary>
        ///     Age of the applicant.
        /// </summary>
        /// <example>27</example>
        public int Age { get; set; }

        /// <summary>
        ///     Determines if applicant is hired or not.
        /// </summary>
        /// <example>False</example>
        public bool Hired { get; set; } = false;

    }
}
