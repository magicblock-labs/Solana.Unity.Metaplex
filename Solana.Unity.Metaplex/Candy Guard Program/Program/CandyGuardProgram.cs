using Solana.Unity.Programs.Utilities;
using Solana.Unity.Wallet;
using System;
using System.Collections.Generic;

namespace Solana.Unity.Metaplex.CandyGuard.Program
{
    public class InitializeAccounts
    {
        public PublicKey CandyGuard { get; set; }

        public PublicKey Base { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey SystemProgram { get; set; }
    }

    public class MintAccounts
    {
        public PublicKey CandyGuard { get; set; }

        public PublicKey CandyMachineProgram { get; set; }

        public PublicKey CandyMachine { get; set; }

        public PublicKey CandyMachineAuthorityPda { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey NftMetadata { get; set; }

        public PublicKey NftMint { get; set; }

        public PublicKey NftMintAuthority { get; set; }

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

        public PublicKey InstructionSysvarAccount { get; set; }
    }

    public class MintV2Accounts
    {
        public PublicKey CandyGuard { get; set; }

        public PublicKey CandyMachineProgram { get; set; }

        public PublicKey CandyMachine { get; set; }

        public PublicKey CandyMachineAuthorityPda { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey Minter { get; set; }

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

    public class RouteAccounts
    {
        public PublicKey CandyGuard { get; set; }

        public PublicKey CandyMachine { get; set; }

        public PublicKey Payer { get; set; }
    }

    public class SetAuthorityAccounts
    {
        public PublicKey CandyGuard { get; set; }

        public PublicKey Authority { get; set; }
    }

    public class UnwrapAccounts
    {
        public PublicKey CandyGuard { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey CandyMachine { get; set; }

        public PublicKey CandyMachineAuthority { get; set; }

        public PublicKey CandyMachineProgram { get; set; }
    }

    public class UpdateAccounts
    {
        public PublicKey CandyGuard { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey SystemProgram { get; set; }
    }

    public class WithdrawAccounts
    {
        public PublicKey CandyGuard { get; set; }

        public PublicKey Authority { get; set; }
    }

    public class WrapAccounts
    {
        public PublicKey CandyGuard { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey CandyMachine { get; set; }

        public PublicKey CandyMachineProgram { get; set; }

        public PublicKey CandyMachineAuthority { get; set; }
    }

    public static class CandyGuardProgram
    {
        public static Solana.Unity.Rpc.Models.TransactionInstruction Initialize(InitializeAccounts accounts, byte[] data, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyGuard, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Base, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(17121445590508351407UL, offset);
            offset += 8;
            _data.WriteS32(data.Length, offset);
            offset += 4;
            _data.WriteSpan(data, offset);
            offset += data.Length;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Mint(MintAccounts accounts, byte[] mintArgs, string label, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyGuard, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyMachineProgram, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachineAuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NftMintAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionUpdateAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.RecentSlothashes, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.InstructionSysvarAccount, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(12000283993290389811UL, offset);
            offset += 8;
            _data.WriteS32(mintArgs.Length, offset);
            offset += 4;
            _data.WriteSpan(mintArgs, offset);
            offset += mintArgs.Length;
            if (label != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += _data.WriteBorshString(label, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction MintV2(MintV2Accounts accounts, byte[] mintArgs, string label, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyGuard, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyMachineProgram, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachineAuthorityPda, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Minter, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.NftMintAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.NftMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Token == null ? programId : accounts.Token, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.TokenRecord == null ? programId : accounts.TokenRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionDelegateRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionUpdateAuthority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SplTokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SplAtaProgram == null ? programId : accounts.SplAtaProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SysvarInstructions, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.RecentSlothashes, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRulesProgram == null ? programId : accounts.AuthorizationRulesProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.AuthorizationRules == null ? programId : accounts.AuthorizationRules, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(14827941989900056952UL, offset);
            offset += 8;
            _data.WriteS32(mintArgs.Length, offset);
            offset += 4;
            _data.WriteSpan(mintArgs, offset);
            offset += mintArgs.Length;
            if (label != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += _data.WriteBorshString(label, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Route(RouteAccounts accounts, RouteArgs args, string label, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyGuard, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(3075364236236101605UL, offset);
            offset += 8;
            offset += args.Serialize(_data, offset);
            if (label != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                offset += _data.WriteBorshString(label, offset);
            }
            else
            {
                _data.WriteU8(0, offset);
                offset += 1;
            }

            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetAuthority(SetAuthorityAccounts accounts, PublicKey newAuthority, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyGuard, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true)};
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

        public static Solana.Unity.Rpc.Models.TransactionInstruction Unwrap(UnwrapAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyGuard, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyMachineAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyMachineProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(3184684663587647358UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Update(UpdateAccounts accounts, byte[] data, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyGuard, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(9222597562720635099UL, offset);
            offset += 8;
            _data.WriteS32(data.Length, offset);
            offset += 4;
            _data.WriteSpan(data, offset);
            offset += data.Length;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Withdraw(WithdrawAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyGuard, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(2495396153584390839UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction Wrap(WrapAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyGuard, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyMachineProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyMachineAuthority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(10140560330402179250UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }
    }
}
