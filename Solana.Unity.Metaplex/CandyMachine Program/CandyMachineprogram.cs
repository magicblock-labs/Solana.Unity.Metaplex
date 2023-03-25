using Solana.Unity.Metaplex.Candymachine.Types;
using Solana.Unity.Programs.Utilities;
using Solana.Unity.Wallet;
using System;
using System.Collections.Generic;
#pragma warning disable CS1591
namespace Solana.Unity.Metaplex.Candymachine
{

    public class InitializeCandyMachineAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Wallet { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey SystemProgram { get; set; }

        public PublicKey Rent { get; set; }
    }

    public class UpdateCandyMachineAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey Wallet { get; set; }
    }

    public class UpdateAuthorityAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey Wallet { get; set; }
    }

    public class AddConfigLinesAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }
    }

    public class SetCollectionAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey CollectionPda { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey SystemProgram { get; set; }

        public PublicKey Rent { get; set; }

        public PublicKey Metadata { get; set; }

        public PublicKey Mint { get; set; }

        public PublicKey Edition { get; set; }

        public PublicKey CollectionAuthorityRecord { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }
    }

    public class RemoveCollectionAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey CollectionPda { get; set; }

        public PublicKey Metadata { get; set; }

        public PublicKey Mint { get; set; }

        public PublicKey CollectionAuthorityRecord { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }
    }

    public class MintNftAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey CandyMachineCreator { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey Wallet { get; set; }

        public PublicKey Metadata { get; set; }

        public PublicKey Mint { get; set; }

        public PublicKey MintAuthority { get; set; }

        public PublicKey UpdateAuthority { get; set; }

        public PublicKey MasterEdition { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey TokenProgram { get; set; }

        public PublicKey SystemProgram { get; set; }

        public PublicKey Rent { get; set; }

        public PublicKey Clock { get; set; }

        public PublicKey RecentBlockhashes { get; set; }

        public PublicKey InstructionSysvarAccount { get; set; }
    }

    public class SetCollectionDuringMintAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Metadata { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey CollectionPda { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey Instructions { get; set; }

        public PublicKey CollectionMint { get; set; }

        public PublicKey CollectionMetadata { get; set; }

        public PublicKey CollectionMasterEdition { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey CollectionAuthorityRecord { get; set; }
    }

    public class WithdrawFundsAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }
    }

    public class SetFreezeAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey FreezePda { get; set; }

        public PublicKey SystemProgram { get; set; }
    }

    public class RemoveFreezeAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey FreezePda { get; set; }
    }

    public class ThawNftAccounts
    {
        public PublicKey FreezePda { get; set; }

        public PublicKey CandyMachine { get; set; }

        public PublicKey TokenAccount { get; set; }

        public PublicKey Owner { get; set; }

        public PublicKey Mint { get; set; }

        public PublicKey Edition { get; set; }

        public PublicKey Payer { get; set; }

        public PublicKey TokenProgram { get; set; }

        public PublicKey TokenMetadataProgram { get; set; }

        public PublicKey SystemProgram { get; set; }
    }

    public class UnlockFundsAccounts
    {
        public PublicKey CandyMachine { get; set; }

        public PublicKey Wallet { get; set; }

        public PublicKey Authority { get; set; }

        public PublicKey FreezePda { get; set; }

        public PublicKey SystemProgram { get; set; }
    }

    public static class CandyMachineProgram
    {
        public static Solana.Unity.Rpc.Models.TransactionInstruction InitializeCandyMachine(InitializeCandyMachineAccounts accounts, CandyMachineData data, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Wallet, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Rent, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(9002738739736709518UL, offset);
            offset += 8;
            offset += data.Serialize(_data, offset);
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction UpdateCandyMachine(UpdateCandyMachineAccounts accounts, CandyMachineData data, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Wallet, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(17255211928133630963UL, offset);
            offset += 8;
            offset += data.Serialize(_data, offset);
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction UpdateAuthority(UpdateAuthorityAccounts accounts, PublicKey newAuthority, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Wallet, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(6409549798474526240UL, offset);
            offset += 8;
            if (newAuthority != null)
            {
                _data.WriteU8(1, offset);
                offset += 1;
                _data.WritePubKey(newAuthority, offset);
                offset += 32;
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

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetCollection(SetCollectionAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Rent, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Metadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Mint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Edition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(16085651328043253440UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction RemoveCollection(RemoveCollectionAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Metadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Mint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionAuthorityRecord, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(11539590303428785375UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction MintNft(MintNftAccounts accounts, byte creatorBump, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyMachineCreator, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Wallet, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Metadata, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Mint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.MintAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.UpdateAuthority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.MasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Rent, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Clock, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.RecentBlockhashes, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.InstructionSysvarAccount, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(18096548587977980371UL, offset);
            offset += 8;
            _data.WriteU8(creatorBump, offset);
            offset += 1;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetCollectionDuringMint(SetCollectionDuringMintAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Metadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionPda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Instructions, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMint, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CollectionMetadata, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionMasterEdition, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Authority, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.CollectionAuthorityRecord, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(4430802569245757799UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction WithdrawFunds(WithdrawFundsAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Authority, true)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(15665806283886109937UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction SetFreeze(SetFreezeAccounts accounts, long freezeTime, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.FreezePda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(16796896651748659402UL, offset);
            offset += 8;
            _data.WriteS64(freezeTime, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction RemoveFreeze(RemoveFreezeAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.FreezePda, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(18099470480020919297UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction ThawNft(ThawNftAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.FreezePda, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.TokenAccount, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Owner, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Mint, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.Edition, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Payer, true), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.TokenMetadataProgram, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(13204561446405549148UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }

        public static Solana.Unity.Rpc.Models.TransactionInstruction UnlockFunds(UnlockFundsAccounts accounts, PublicKey programId)
        {
            List<Solana.Unity.Rpc.Models.AccountMeta> keys = new()
                {Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.CandyMachine, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Wallet, false), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.Authority, true), Solana.Unity.Rpc.Models.AccountMeta.Writable(accounts.FreezePda, false), Solana.Unity.Rpc.Models.AccountMeta.ReadOnly(accounts.SystemProgram, false)};
            byte[] _data = new byte[1200];
            int offset = 0;
            _data.WriteU64(3170313745533532079UL, offset);
            offset += 8;
            byte[] resultData = new byte[offset];
            Array.Copy(_data, resultData, offset);
            return new Solana.Unity.Rpc.Models.TransactionInstruction { Keys = keys, ProgramId = programId.KeyBytes, Data = resultData };
        }
    }
}