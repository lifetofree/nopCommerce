﻿namespace Nop.Core.Domain.Security
{
    /// <summary>
    /// Represents an captcha type
    /// </summary>
    public enum CaptchaType
    {
        /// <summary>
        /// Use reCAPTCHA v2 check box
        /// </summary>
        CheckBoxReCaptchaV2 = 10,

        /// <summary>
        /// Use reCAPTCHA v3
        /// </summary>
        ReCaptchaV3 = 20,
    }
}