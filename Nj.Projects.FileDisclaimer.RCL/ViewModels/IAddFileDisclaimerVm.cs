﻿/* This file is copyright © 2022 Dnj.Colab repository authors.

Dnj.Colab content is distributed as free software: you can redistribute it and/or modify it under the terms of the General Public License version 3 as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

Dnj.Colab content is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the General Public License version 3 for more details.

You should have received a copy of the General Public License version 3 along with this repository. If not, see <https://github.com/smaicas-org/Dnj.Colab/blob/dev/LICENSE>. */

namespace Nj.Projects.FileDisclaimer.RCL.ViewModels;

public interface IAddFileDisclaimerVm
{
    string? DestinyFolder { get; set; }
    FileExtensionComment[] AllowedFileExtensions { get; set; }
    string? DisclaimerText { get; set; }
    bool Loading { get; set; }
    string? Error { get; set; }
    int ProcessedFileNumber { get; set; }
    Task SelectDestinyFolder();
    Task<AddFileDisclaimerResult> Generate();
}

public class AddFileDisclaimerResult
{
    public AddFileDisclaimerResultState State { get; set; }
    public string? Error { get; set; }
    public int ProcessedFileNumber { get; set; }
}

public enum AddFileDisclaimerResultState
{
    OK,
    KO
}

public class FileExtensionComment
{
    public string? Value { get; set; }
    public string? CommentOpen { get; set; }
    public string? CommentClose { get; set; }
}