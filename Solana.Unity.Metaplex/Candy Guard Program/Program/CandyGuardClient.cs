using Solana.Unity.Metaplex.CandyGuard.Errors;
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

namespace Solana.Unity.Metaplex.CandyGuard.Program
{
    public partial class CandyGuardClient : TransactionalBaseClient<CandyGuardErrorKind>
    {
        public CandyGuardClient(IRpcClient rpcClient, IStreamingRpcClient streamingRpcClient, PublicKey programId) : base(rpcClient, streamingRpcClient, programId)
        {
        }

        public async Task<Solana.Unity.Programs.Models.ProgramAccountsResultWrapper<List<Accounts.CandyGuardAccounts.FreezeEscrow>>> GetFreezeEscrowsAsync(string programAddress, Commitment commitment = Commitment.Finalized)
        {
            var list = new List<Solana.Unity.Rpc.Models.MemCmp> { new Solana.Unity.Rpc.Models.MemCmp { Bytes = Accounts.CandyGuardAccounts.FreezeEscrow.ACCOUNT_DISCRIMINATOR_B58, Offset = 0 } };
            var res = await RpcClient.GetProgramAccountsAsync(programAddress, commitment, memCmpList: list);
            if (!res.WasSuccessful || !(res.Result?.Count > 0))
                return new Solana.Unity.Programs.Models.ProgramAccountsResultWrapper<List<Accounts.CandyGuardAccounts.FreezeEscrow>>(res);
            List<Accounts.CandyGuardAccounts.FreezeEscrow> resultingAccounts = new List<Accounts.CandyGuardAccounts.FreezeEscrow>(res.Result.Count);
            resultingAccounts.AddRange(res.Result.Select(result => Accounts.CandyGuardAccounts.FreezeEscrow.Deserialize(Convert.FromBase64String(result.Account.Data[0]))));
            return new Solana.Unity.Programs.Models.ProgramAccountsResultWrapper<List<Accounts.CandyGuardAccounts.FreezeEscrow>>(res, resultingAccounts);
        }

        public async Task<Solana.Unity.Programs.Models.ProgramAccountsResultWrapper<List<CandyGuard.Accounts.CandyGuardAccounts.CandyGuard>>> GetCandyGuardsAsync(string programAddress, Commitment commitment = Commitment.Finalized)
        {
            var list = new List<Solana.Unity.Rpc.Models.MemCmp> { new Solana.Unity.Rpc.Models.MemCmp { Bytes = CandyGuard.Accounts.CandyGuardAccounts.CandyGuard.ACCOUNT_DISCRIMINATOR_B58, Offset = 0 } };
            var res = await RpcClient.GetProgramAccountsAsync(programAddress, commitment, memCmpList: list);
            if (!res.WasSuccessful || !(res.Result?.Count > 0))
                return new Solana.Unity.Programs.Models.ProgramAccountsResultWrapper<List<CandyGuard.Accounts.CandyGuardAccounts.CandyGuard>>(res);
            List<CandyGuard.Accounts.CandyGuardAccounts.CandyGuard> resultingAccounts = new List<CandyGuard.Accounts.CandyGuardAccounts.CandyGuard>(res.Result.Count);
            resultingAccounts.AddRange(res.Result.Select(result => CandyGuard.Accounts.CandyGuardAccounts.CandyGuard.Deserialize(Convert.FromBase64String(result.Account.Data[0]))));
            return new Solana.Unity.Programs.Models.ProgramAccountsResultWrapper<List<CandyGuard.Accounts.CandyGuardAccounts.CandyGuard>>(res, resultingAccounts);
        }

        public async Task<Solana.Unity.Programs.Models.AccountResultWrapper<Accounts.CandyGuardAccounts.FreezeEscrow>> GetFreezeEscrowAsync(string accountAddress, Commitment commitment = Commitment.Finalized)
        {
            var res = await RpcClient.GetAccountInfoAsync(accountAddress, commitment);
            if (!res.WasSuccessful)
                return new Solana.Unity.Programs.Models.AccountResultWrapper<Accounts.CandyGuardAccounts.FreezeEscrow>(res);
            var resultingAccount = Accounts.CandyGuardAccounts.FreezeEscrow.Deserialize(Convert.FromBase64String(res.Result.Value.Data[0]));
            return new Solana.Unity.Programs.Models.AccountResultWrapper<Accounts.CandyGuardAccounts.FreezeEscrow>(res, resultingAccount);
        }

        public async Task<Solana.Unity.Programs.Models.AccountResultWrapper<CandyGuard.Accounts.CandyGuardAccounts.CandyGuard>> GetCandyGuardAsync(string accountAddress, Commitment commitment = Commitment.Finalized)
        {
            var res = await RpcClient.GetAccountInfoAsync(accountAddress, commitment);
            if (!res.WasSuccessful)
                return new Solana.Unity.Programs.Models.AccountResultWrapper<CandyGuard.Accounts.CandyGuardAccounts.CandyGuard>(res);
            var resultingAccount = CandyGuard.Accounts.CandyGuardAccounts.CandyGuard.Deserialize(Convert.FromBase64String(res.Result.Value.Data[0]));
            return new Solana.Unity.Programs.Models.AccountResultWrapper<CandyGuard.Accounts.CandyGuardAccounts.CandyGuard>(res, resultingAccount);
        }

        public async Task<SubscriptionState> SubscribeFreezeEscrowAsync(string accountAddress, Action<SubscriptionState, Solana.Unity.Rpc.Messages.ResponseValue<Solana.Unity.Rpc.Models.AccountInfo>, Accounts.CandyGuardAccounts.FreezeEscrow> callback, Commitment commitment = Commitment.Finalized)
        {
            SubscriptionState res = await StreamingRpcClient.SubscribeAccountInfoAsync(accountAddress, (s, e) =>
            {
                Solana.Unity.Metaplex.CandyGuard.Accounts.CandyGuardAccounts.FreezeEscrow parsingResult = null;
                if (e.Value?.Data?.Count > 0)
                    parsingResult = Accounts.CandyGuardAccounts.FreezeEscrow.Deserialize(Convert.FromBase64String(e.Value.Data[0]));
                callback(s, e, parsingResult);
            }, commitment);
            return res;
        }

        public async Task<SubscriptionState> SubscribeCandyGuardAsync(string accountAddress, Action<SubscriptionState, Solana.Unity.Rpc.Messages.ResponseValue<Solana.Unity.Rpc.Models.AccountInfo>, CandyGuard.Accounts.CandyGuardAccounts.CandyGuard> callback, Commitment commitment = Commitment.Finalized)
        {
            SubscriptionState res = await StreamingRpcClient.SubscribeAccountInfoAsync(accountAddress, (s, e) =>
            {
                CandyGuard.Accounts.CandyGuardAccounts.CandyGuard parsingResult = null;
                if (e.Value?.Data?.Count > 0)
                    parsingResult = CandyGuard.Accounts.CandyGuardAccounts.CandyGuard.Deserialize(Convert.FromBase64String(e.Value.Data[0]));
                callback(s, e, parsingResult);
            }, commitment);
            return res;
        }

        public async Task<RequestResult<string>> SendInitializeAsync(InitializeAccounts accounts, byte[] data, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = Program.CandyGuardProgram.Initialize(accounts, data, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendMintAsync(MintAccounts accounts, byte[] mintArgs, string label, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = Program.CandyGuardProgram.Mint(accounts, mintArgs, label, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendMintV2Async(MintV2Accounts accounts, byte[] mintArgs, string label, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = Program.CandyGuardProgram.MintV2(accounts, mintArgs, label, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendRouteAsync(RouteAccounts accounts, RouteArgs args, string label, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = Program.CandyGuardProgram.Route(accounts, args, label, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendSetAuthorityAsync(SetAuthorityAccounts accounts, PublicKey newAuthority, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = Program.CandyGuardProgram.SetAuthority(accounts, newAuthority, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendUnwrapAsync(UnwrapAccounts accounts, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = Program.CandyGuardProgram.Unwrap(accounts, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendUpdateAsync(UpdateAccounts accounts, byte[] data, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = Program.CandyGuardProgram.Update(accounts, data, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendWithdrawAsync(WithdrawAccounts accounts, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = Program.CandyGuardProgram.Withdraw(accounts, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        public async Task<RequestResult<string>> SendWrapAsync(WrapAccounts accounts, PublicKey feePayer, Func<byte[], PublicKey, byte[]> signingCallback, PublicKey programId)
        {
            Solana.Unity.Rpc.Models.TransactionInstruction instr = Program.CandyGuardProgram.Wrap(accounts, programId);
            return await SignAndSendTransaction(instr, feePayer, signingCallback);
        }

        protected override Dictionary<uint, ProgramError<CandyGuardErrorKind>> BuildErrorsDictionary()
        {
            return new Dictionary<uint, ProgramError<CandyGuardErrorKind>> { { 6000U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.InvalidAccountSize, "Could not save guard to account") }, { 6001U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.DeserializationError, "Could not deserialize guard") }, { 6002U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.PublicKeyMismatch, "Public key mismatch") }, { 6003U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.DataIncrementLimitExceeded, "Exceeded account increase limit") }, { 6004U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.IncorrectOwner, "Account does not have correct owner") }, { 6005U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.Uninitialized, "Account is not initialized") }, { 6006U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MissingRemainingAccount, "Missing expected remaining account") }, { 6007U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.NumericalOverflowError, "Numerical overflow error") }, { 6008U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.RequiredGroupLabelNotFound, "Missing required group label") }, { 6009U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.GroupNotFound, "Group not found") }, { 6010U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.ExceededLength, "Value exceeded maximum length") }, { 6011U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.CandyMachineEmpty, "Candy machine is empty") }, { 6012U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.InstructionNotFound, "No instruction was found") }, { 6013U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.CollectionKeyMismatch, "Collection public key mismatch") }, { 6014U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MissingCollectionAccounts, "Missing collection accounts") }, { 6015U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.CollectionUpdateAuthorityKeyMismatch, "Collection update authority public key mismatch") }, { 6016U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MintNotLastTransaction, "Mint must be the last instructions of the transaction") }, { 6017U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MintNotLive, "Mint is not live") }, { 6018U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.NotEnoughSOL, "Not enough SOL to pay for the mint") }, { 6019U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.TokenBurnFailed, "Token burn failed") }, { 6020U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.NotEnoughTokens, "Not enough tokens on the account") }, { 6021U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.TokenTransferFailed, "Token transfer failed") }, { 6022U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MissingRequiredSignature, "A signature was required but not found") }, { 6023U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.GatewayTokenInvalid, "Gateway token is not valid") }, { 6024U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.AfterEndDate, "Current time is after the set end date") }, { 6025U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.InvalidMintTime, "Current time is not within the allowed mint time") }, { 6026U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.AddressNotFoundInAllowedList, "Address not found on the allowed list") }, { 6027U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MissingAllowedListProof, "Missing allowed list proof") }, { 6028U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.AllowedListNotEnabled, "Allow list guard is not enabled") }, { 6029U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.AllowedMintLimitReached, "The maximum number of allowed mints was reached") }, { 6030U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.InvalidNftCollection, "Invalid NFT collection") }, { 6031U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MissingNft, "Missing NFT on the account") }, { 6032U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MaximumRedeemedAmount, "Current redemeed items is at the set maximum amount") }, { 6033U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.AddressNotAuthorized, "Address not authorized") }, { 6034U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MissingFreezeInstruction, "Missing freeze instruction data") }, { 6035U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.FreezeGuardNotEnabled, "Freeze guard must be enabled") }, { 6036U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.FreezeNotInitialized, "Freeze must be initialized") }, { 6037U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.MissingFreezePeriod, "Missing freeze period") }, { 6038U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.FreezeEscrowAlreadyExists, "The freeze escrow account already exists") }, { 6039U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.ExceededMaximumFreezePeriod, "Maximum freeze period exceeded") }, { 6040U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.ThawNotEnabled, "Thaw is not enabled") }, { 6041U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.UnlockNotEnabled, "Unlock is not enabled (not all NFTs are thawed)") }, { 6042U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.DuplicatedGroupLabel, "Duplicated group label") }, { 6043U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.DuplicatedMintLimitId, "Duplicated mint limit id") }, { 6044U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.UnauthorizedProgramFound, "An unauthorized program was found in the transaction") }, { 6045U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.ExceededProgramListSize, "Exceeded the maximum number of programs in the additional list") }, { 6046U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.AllocationNotInitialized, "Allocation PDA not initialized") }, { 6047U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.AllocationLimitReached, "Allocation limit was reached") }, { 6048U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.AllocationGuardNotEnabled, "Allocation guard must be enabled") }, { 6049U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.InvalidMintAuthority, "Candy machine has an invalid mint authority") }, { 6050U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.InstructionBuilderFailed, "Instruction could not be created") }, { 6051U, new ProgramError<CandyGuardErrorKind>(CandyGuardErrorKind.InvalidAccountVersion, "Invalid account version") }, };
        }
    }
}
