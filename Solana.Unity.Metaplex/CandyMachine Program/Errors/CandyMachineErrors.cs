namespace Solana.Unity.Metaplex.Candymachine.Errors
{
#pragma warning disable CS1591
    public enum CandyMachineErrorKind : uint
        {
            IncorrectOwner = 6000U,
            Uninitialized = 6001U,
            MintMismatch = 6002U,
            IndexGreaterThanLength = 6003U,
            NumericalOverflowError = 6004U,
            TooManyCreators = 6005U,
            CandyMachineEmpty = 6006U,
            HiddenSettingsDoNotHaveConfigLines = 6007U,
            CannotChangeNumberOfLines = 6008U,
            CannotSwitchToHiddenSettings = 6009U,
            IncorrectCollectionAuthority = 6010U,
            MetadataAccountMustBeEmpty = 6011U,
            NoChangingCollectionDuringMint = 6012U,
            ExceededLengthError = 6013U,
            MissingConfigLinesSettings = 6014U,
            CannotIncreaseLength = 6015U,
            CannotSwitchFromHiddenSettings = 6016U,
            CannotChangeSequentialIndexGeneration = 6017U,
            CollectionKeyMismatch = 6018U,
            CouldNotRetrieveConfigLineData = 6019U,
            NotFullyLoaded = 6020U,
            InstructionBuilderFailed = 6021U,
            MissingCollectionAuthorityRecord = 6022U,
            MissingMetadataDelegateRecord = 6023U,
            InvalidTokenStandard = 6024U,
            MissingTokenAccount = 6025U,
            MissingTokenRecord = 6026U,
            MissingInstructionsSysvar = 6027U,
            MissingSplAtaProgram = 6028U,
            InvalidAccountVersion = 6029U
        }
    }
