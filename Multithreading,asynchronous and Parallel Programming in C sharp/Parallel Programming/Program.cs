/*
 * What is Parallel Programming ?
 * 
 *      It is programming technique where the execution flow of the application is broken up into pieces that 
 *      will be done at same time (concurrently) by multiple cores, processors, or computers for the sake of 
 *      better performance.
 *      
 *      It is a type of programming in which many calculations or the execution of processes are carried out simultaneously.
 *      
 * C# Supports 2 types of parallelism:
 * 
 *      Data Parallelism:
 *          Here operation is applied to each element of a collection.
 *          This means each process does the same work on unique & independent piece of data.
 *          
 *          Parallel.For, Parallel.ForEach
 *          
 *      Task Parallelism:
 *          Here independent computations are executed in parallel.
 *          This means each process performs different function or execute different code sections thar are independent.
 *          
 *          Parallel.Invoke
 *          
 * What is Task Parallel Library (TPL) ?
 * 
 *      It is a set of publictypes & APIs in System.Threading & System.Threading.Tasks namespaces.
 *      The purpose of TPL is to make developer more productive by simplifying the process of adding parallelism & concurrency to application.
 *      TPL is the preferred way to write multithreaded and parallel code.
 *  
 */