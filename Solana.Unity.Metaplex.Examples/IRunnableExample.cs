using System.Threading.Tasks;

namespace Solana.Unity.Metaplex.Examples
{
    /// <summary>
    /// Defines functionality for an example.
    /// </summary>
    public interface IRunnableExample
    {
        /// <summary>
        /// Run the example.
        /// </summary>
        Task Run();
    }
}