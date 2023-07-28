using Solana.Unity.Metaplex.Candymachine.Accounts;
using Solana.Unity.Metaplex.Candymachine.Errors;
using Solana.Unity.Metaplex.Candymachine.Types;
using Solana.Unity.Programs.Abstract;
using Solana.Unity.Rpc;
using Solana.Unity.Rpc.Core.Http;
using Solana.Unity.Rpc.Core.Sockets;
using Solana.Unity.Rpc.Types;
using Solana.Unity.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#pragma warning disable CS1591
namespace Solana.Unity.Metaplex.Candymachine
{
    /// <summary>
    /// CandyMachine client for Metaplex protocol
    /// </summary>
    public partial class CandyMachineClient : TransactionalBaseClient<CandyMachineErrorKind>
    {
        public CandyMachineClient(IRpcClient rpcClient, IStreamingRpcClient streamingRpcClient, PublicKey programId) : base(rpcClient, streamingRpcClient, programId)
        {
        }

        public async Task<Solana.Unity.Programs.Models.ProgramAccountsResultWrapper<List<CandyMachine>>> GetCandyMachinesAsync(string programAddress, Commitment commitment = Commitment.Finalized)
        {
            var list = new List<Solana.Unity.Rpc.Models.MemCmp> { new Solana.Unity.Rpc.Models.MemCmp { Bytes = CandyMachine.ACCOUNT_DISCRIMINATOR_B58, Offset = 0 } };
            var res = await RpcClient.GetProgramAccountsAsync(programAddress, commitment, memCmpList: list);
            if (!res.WasSuccessful || !(res.Result?.Count > 0))
                return new Solana.Unity.Programs.Models.ProgramAccountsResultWrapper<List<CandyMachine>>(res);
            List<CandyMachine> resultingAccounts = new List<CandyMachine>(res.Result.Count);
            resultingAccounts.AddRange(res.Result.Select(result => CandyMachine.Deserialize(Convert.FromBase64String(result.Account.Data[0]))));
            return new Solana.Unity.Programs.Models.ProgramAccountsResultWrapper<List<CandyMachine>>(res, resultingAccounts);
        }

        public async Task<Solana.Unity.Programs.Models.AccountResultWrapper<CandyMachine>> GetCandyMachineAsync(string accountAddress, Commitment commitment = Commitment.Finalized)
        {
            var res = await RpcClient.GetAccountInfoAsync(accountAddress, commitment);
            if (!res.WasSuccessful)
                return new Solana.Unity.Programs.Models.AccountResultWrapper<CandyMachine>(res);
            var resultingAccount = CandyMachine.Deserialize(Convert.FromBase64String(res.Result.Value.Data[0]));
            return new Solana.Unity.Programs.Models.AccountResultWrapper<CandyMachine>(res, resultingAccount);
        }

        public async Task<SubscriptionState> SubscribeCandyMachineAsync(string accountAddress, Action<SubscriptionState, Solana.Unity.Rpc.Messages.ResponseValue<Solana.Unity.Rpc.Models.AccountInfo>, CandyMachine> callback, Commitment commitment = Commitment.Finalized)
        {
            SubscriptionState res = await StreamingRpcClient.SubscribeAccountInfoAsync(accountAddress, (s, e) =>
            {
                CandyMachine parsingResult = null;
                if (e.Value?.Data?.Count > 0)
                    parsingResult = CandyMachine.Deserialize(Convert.FromBase64String(e.Value.Data[0]));
                callback(s, e, parsingResult);
            }, commitment);
            return res;
        }

        public async Task<RequestResult<string>> SendAddConfigLinesAsync(AddConfigLinesAccounts accounts, uint index, ConfigLine[] configLines, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.AddConfigLines(accounts, index, configLines, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendInitializeAsync(InitializeAccounts accounts, CandyMachineData data, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.Initialize(accounts, data, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendInitializeV2Async(InitializeV2Accounts accounts, CandyMachineData data, byte tokenStandard, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.InitializeV2(accounts, data, tokenStandard, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendMintAsync(MintAccounts accounts, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.Mint(accounts, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendMintV2Async(MintV2Accounts accounts, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.MintV2(accounts, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendSetAuthorityAsync(SetAuthorityAccounts accounts, PublicKey newAuthority, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.SetAuthority(accounts, newAuthority, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendSetCollectionAsync(SetCollectionAccounts accounts, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.SetCollection(accounts, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendSetCollectionV2Async(SetCollectionV2Accounts accounts, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.SetCollectionV2(accounts, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendSetMintAuthorityAsync(SetMintAuthorityAccounts accounts, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.SetMintAuthority(accounts, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendSetTokenStandardAsync(SetTokenStandardAccounts accounts, byte tokenStandard, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.SetTokenStandard(accounts, tokenStandard, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendUpdateAsync(UpdateAccounts accounts, CandyMachineData data, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.Update(accounts, data, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendWithdrawAsync(WithdrawAccounts accounts, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = CandyMachineProgram.Withdraw(accounts, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        protected override Dictionary<uint, ProgramError<CandyMachineErrorKind>> BuildErrorsDictionary()
        {
            return new Dictionary<uint, ProgramError<CandyMachineErrorKind>> { { 6000U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.IncorrectOwner, "Account does not have correct owner") }, { 6001U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.Uninitialized, "Account is not initialized") }, { 6002U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.MintMismatch, "Mint Mismatch") }, { 6003U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.IndexGreaterThanLength, "Index greater than length") }, { 6004U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.NumericalOverflowError, "Numerical overflow error") }, { 6005U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.TooManyCreators, "Can only provide up to 4 creators to candy machine (because candy machine is one)") }, { 6006U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.CandyMachineEmpty, "Candy machine is empty") }, { 6007U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.HiddenSettingsDoNotHaveConfigLines, "Candy machines using hidden uris do not have config lines, they have a single hash representing hashed order") }, { 6008U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.CannotChangeNumberOfLines, "Cannot change number of lines unless is a hidden config") }, { 6009U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.CannotSwitchToHiddenSettings, "Cannot switch to hidden settings after items available is greater than 0") }, { 6010U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.IncorrectCollectionAuthority, "Incorrect collection NFT authority") }, { 6011U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.MetadataAccountMustBeEmpty, "The metadata account has data in it, and this must be empty to mint a new NFT") }, { 6012U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.NoChangingCollectionDuringMint, "Can't change collection settings after items have begun to be minted") }, { 6013U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.ExceededLengthError, "Value longer than expected maximum value") }, { 6014U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.MissingConfigLinesSettings, "Missing config lines settings") }, { 6015U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.CannotIncreaseLength, "Cannot increase the length in config lines settings") }, { 6016U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.CannotSwitchFromHiddenSettings, "Cannot switch from hidden settings") }, { 6017U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.CannotChangeSequentialIndexGeneration, "Cannot change sequential index generation after items have begun to be minted") }, { 6018U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.CollectionKeyMismatch, "Collection public key mismatch") }, { 6019U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.CouldNotRetrieveConfigLineData, "Could not retrive config line data") }, { 6020U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.NotFullyLoaded, "Not all config lines were added to the candy machine") }, { 6021U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.InstructionBuilderFailed, "Instruction could not be created") }, { 6022U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.MissingCollectionAuthorityRecord, "Missing collection authority record") }, { 6023U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.MissingMetadataDelegateRecord, "Missing metadata delegate record") }, { 6024U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.InvalidTokenStandard, "Invalid token standard") }, { 6025U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.MissingTokenAccount, "Missing token account") }, { 6026U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.MissingTokenRecord, "Missing token record") }, { 6027U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.MissingInstructionsSysvar, "Missing instructions sysvar account") }, { 6028U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.MissingSplAtaProgram, "Missing SPL ATA program") }, { 6029U, new ProgramError<CandyMachineErrorKind>(CandyMachineErrorKind.InvalidAccountVersion, "Invalid account version") }, };
        }
    }
}
