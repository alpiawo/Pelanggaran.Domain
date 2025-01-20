import { Link } from "react-router-dom";
import { 
    HiAcademicCap,
    HiChartBar,
    HiClipboard,
    HiMiniClipboardDocumentList,
    HiMiniUser,
    HiMiniUserGroup
 } from "react-icons/hi2"


export function Navbar() {
    return (
        <div>
            <aside id="default-sidebar" class="fixed top-0 left-0 z-40 w-64 h-screen transition-transform -translate-x-full sm:translate-x-0" aria-label="Sidebar">
                <div class="h-full px-3 py-4 overflow-y-auto bg-gray-50 dark:bg-gray-800">
                    <ul class="space-y-2 font-medium">
                        <p className="text-white font-bold text-2xl mb-10">Pelanggaran Siswa</p>
                        <li>
                            <Link to="/" class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                                <HiChartBar className="text-2xl text-slate-400"/>
                                <span class="ms-3">Dashboard</span>
                            </Link>
                        </li>
                        <li>
                            <Link to="/jurusan" class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                                <HiAcademicCap className="text-2xl text-slate-400"/>
                                <span class="flex-1 ms-3 whitespace-nowrap">Jurusan</span>
                            </Link>
                        </li>
                        <li>
                            <Link to="#" class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                                <HiClipboard className="text-2xl text-slate-400"/>
                                <span class="flex-1 ms-3 whitespace-nowrap">Kelas</span>
                            </Link>
                        </li>
                        <li>
                            <Link to="#" class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                                <HiMiniClipboardDocumentList className="text-2xl text-slate-400"/>
                                <span class="flex-1 ms-3 whitespace-nowrap">Peraturan</span>
                            </Link>
                        </li>
                        <li>
                            <Link to="#" class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                                <HiMiniUser className="text-2xl text-slate-400"/>
                                <span class="flex-1 ms-3 whitespace-nowrap">Pengajar</span>
                            </Link>
                        </li>
                        <li>
                            <Link to="#" class="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group">
                                <HiMiniUserGroup className="text-2xl text-slate-400"/>
                                <span class="flex-1 ms-3 whitespace-nowrap">Siswa</span>
                            </Link>
                        </li>
                    </ul>
                </div>
            </aside>
        </div>
    );
}