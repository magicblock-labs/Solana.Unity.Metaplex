using Solana.Unity.Metaplex.Candymachine.Types;
using Solana.Unity.Programs.Utilities;
using Solana.Unity.Wallet;
using System;
using System.Collections.Generic;
#pragma warning disable CS1591
namespace Solana.Unity.Metaplex.Candymachine
{

    public class AddConfigLinesAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }
    }

    public class InitializeAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey AuthorityPda { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey CollectionMetadata { get; set; }

        public PublicKey CollectionMint { get; set; }

        public PublicKey CollectionMasterEdition { get; set; }

        public PublicKey CollectionUpdateAuthority { get; set; }

        public PublicKey CollectionAuthorityRecord { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey SystemProgram { get; set; }
    }

    public class InitializeV2Accounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey AuthorityPda { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey RuleSet { get; set; }

        public PublicKey CollectionMetadata { get; set; }

        public PublicKey CollectionMint { get; set; }

        public PublicKey CollectionMasterEdition { get; set; }

        public PublicKey CollectionUpdateAuthority { get; set; }

        public PublicKey CollectionDelegateRecord { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey SystemProgram { get; set; }

        public PublicKey SysvarInstructions { get; set; }

        public PublicKey AuthorizationRulesProgram { get; set; }

        public PublicKey AuthorizationRules { get; set; }
    }

    public class MintAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey AuthorityPda { get; set; }

        public PublicKey MintAuthority { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey NftMint { get; set; }

        public PublicKey NftMintAuthority { get; set; }

        public PublicKey NftMetadata { get; set; }

        public PublicKey NftMasterEdition { get; set; }

        public PublicKey CollectionAuthorityRecord { get; set; }

        public PublicKey CollectionMint { get; set; }

        public PublicKey CollectionMetadata { get; set; }

        public PublicKey CollectionMasterEdition { get; set; }

        public PublicKey CollectionUpdateAuthority { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey TokenProgram { get; set; }

        public PublicKey SystemProgram { get; set; }

        public PublicKey RecentSlothashes { get; set; }
    }

    public class MintV2Accounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey AuthorityPda { get; set; }

        public PublicKey MintAuthority { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey NftOwner { get; set; }

        public PublicKey NftMint { get; set; }

        public PublicKey NftMintAuthority { get; set; }

        public PublicKey NftMetadata { get; set; }

        public PublicKey NftMasterEdition { get; set; }

        public PublicKey Token { get; set; }

        public PublicKey TokenRecord { get; set; }

        public PublicKey CollectionDelegateRecord { get; set; }

        public PublicKey CollectionMint { get; set; }

        public PublicKey CollectionMetadata { get; set; }

        public PublicKey CollectionMasterEdition { get; set; }

        public PublicKey CollectionUpdateAuthority { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey SplTokenProgram { get; set; }

        public PublicKey SplAtaProgram { get; set; }

        public PublicKey SystemProgram { get; set; }

        public PublicKey SysvarInstructions { get; set; }

        public PublicKey RecentSlothashes { get; set; }

        public PublicKey AuthorizationRulesProgram { get; set; }

        public PublicKey AuthorizationRules { get; set; }
    }

    public class SetAuthorityAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }
    }

    public class SetCollectionAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey AuthorityPda { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey CollectionMint { get; set; }

        public PublicKey CollectionMetadata { get; set; }

        public PublicKey CollectionAuthorityRecord { get; set; }

        public PublicKey NewCollectionUpdateAuthority { get; set; }

        public PublicKey NewCollectionMetadata { get; set; }

        public PublicKey NewCollectionMint { get; set; }

        public PublicKey NewCollectionMasterEdition { get; set; }

        public PublicKey NewCollectionAuthorityRecord { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey SystemProgram { get; set; }
    }

    public class SetCollectionV2Accounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey AuthorityPda { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey CollectionUpdateAuthority { get; set; }

        public PublicKey CollectionMint { get; set; }

        public PublicKey CollectionMetadata { get; set; }

        public PublicKey CollectionDelegateRecord { get; set; }

        public PublicKey NewCollectionUpdateAuthority { get; set; }

        public PublicKey NewCollectionMint { get; set; }

        public PublicKey NewCollectionMetadata { get; set; }

        public PublicKey NewCollectionMasterEdition { get; set; }

        public PublicKey NewCollectionDelegateRecord { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey SystemProgram { get; set; }

        public PublicKey SysvarInstructions { get; set; }

        public PublicKey AuthorizationRulesProgram { get; set; }

        public PublicKey AuthorizationRules { get; set; }
    }

    public class SetMintAuthorityAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey MintAuthority { get; set; }
    }

    public class SetTokenStandardAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey AuthorityPda { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey RuleSet { get; set; }

        public PublicKey CollectionDelegateRecord { get; set; }

        public PublicKey CollectionMint { get; set; }

        public PublicKey CollectionMetadata { get; set; }

        public PublicKey CollectionAuthorityRecord { get; set; }

        public PublicKey CollectionUpdateAuthority { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey SystemProgram { get; set; }

        public PublicKey SysvarInstructions { get; set; }

        public PublicKey AuthorizationRulesProgram { get; set; }

        public PublicKey AuthorizationRules { get; set; }
    }

    public class UpdateAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }
    }

    public class WithdrawAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }
    }

    public static class CandyMachineProgram
    {
        public static Solana.Unity.Rpc.Models.TransactionInstruction AddConfigLines(AddConfigLinesAccounts accounts, uint index, ConfigLine[] configLines, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(7670484038798291679UL, offset);
            offset += 8;
            _data.WriteU32(index, offset);
            offset += 4;
            _data.WriteS32(configLines.Length, offset);
            offset += 4;
            foreach (var configLinesElement in configLines)
            {
                offset += configLinesElement.Serialize(_data, offset);
            }

            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Initialize(InitializeAccounts accounts, CandyMachineData data, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionUpdateAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(17121445590508351407UL, offset);
            offset += 8;
            offset += data.Serialize(_data, offset);
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction InitializeV2(InitializeV2Accounts accounts, CandyMachineData data, byte tokenStandard, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.RuleSet == null ? programId : accounts.RuleSet, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionUpdateAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionDelegateRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SysvarInstructions, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRulesProgram == null ? programId : accounts.AuthorizationRulesProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRules == null ? programId : accounts.AuthorizationRules, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(2316557587483433283UL, offset);
            offset += 8;
            offset += data.Serialize(_data, offset);
            _data.WriteU8(tokenStandard, offset);
            offset += 1;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Mint(MintAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.MintAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NftMintAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionUpdateAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.RecentSlothashes, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(12000283993290389811UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction MintV2(MintV2Accounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.MintAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NftOwner, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NftMintAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Token == null ? programId : accounts.Token, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.TokenRecord == null ? programId : accounts.TokenRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionDelegateRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionUpdateAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SplTokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SplAtaProgram == null ? programId : accounts.SplAtaProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SysvarInstructions, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.RecentSlothashes, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRulesProgram == null ? programId : accounts.AuthorizationRulesProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRules == null ? programId : accounts.AuthorizationRules, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(14827941989900056952UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetAuthority(SetAuthorityAccounts accounts, PublicKey newAuthority, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(8726466921180297861UL, offset);
            offset += 8;
            _data.WritePubKey(newAuthority, offset);
            offset += 32;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetCollection(SetCollectionAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NewCollectionUpdateAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewCollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewCollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewCollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NewCollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(16085651328043253440UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetCollectionV2(SetCollectionV2Accounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionUpdateAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionDelegateRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewCollectionUpdateAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewCollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NewCollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NewCollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NewCollectionDelegateRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SysvarInstructions, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRulesProgram == null ? programId : accounts.AuthorizationRulesProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRules == null ? programId : accounts.AuthorizationRules, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(11557096527880856549UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetMintAuthority(SetMintAuthorityAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.MintAuthority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(8748152548857970499UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetTokenStandard(SetTokenStandardAccounts accounts, byte tokenStandard, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.AuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.RuleSet == null ? programId : accounts.RuleSet, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionDelegateRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionAuthorityRecord == null ? programId : accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionUpdateAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SysvarInstructions, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRulesProgram == null ? programId : accounts.AuthorizationRulesProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRules == null ? programId : accounts.AuthorizationRules, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(9282387356091602067UL, offset);
            offset += 8;
            _data.WriteU8(tokenStandard, offset);
            offset += 1;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Update(UpdateAccounts accounts, CandyMachineData data, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(9222597562720635099UL, offset);
            offset += 8;
            offset += data.Serialize(_data, offset);
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Withdraw(WithdrawAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(2495396153584390839UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }
    }
}