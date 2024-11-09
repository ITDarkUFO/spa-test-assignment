import { Layout } from 'antd';

import { DataFetchProvider } from './context/DataFetchContext';
import { ModalProvider } from './context/ModalContext';

import PageContent from './components/PageContent';
import CreateProductModal from './components/CreateProductModal';
import ViewEditProductModal from './components/ViewEditProductModal';

import './App.css'

const { innerHeight: height } = window;
const { Header, Content, Footer } = Layout;

function App() {
    return (
        <Layout style={{ minHeight: height }}>
            <Header>
            </Header>
            <Content className="content-wrapper">
                <DataFetchProvider>
                    <ModalProvider>
                        <PageContent />
                        <CreateProductModal />
                        <ViewEditProductModal />
                    </ModalProvider>
                </DataFetchProvider>
            </Content>
            <Footer style={{ textAlign: 'center' }} >
                Одностраничное приложение магазина &ndash; Тестовое задание
            </Footer>
        </Layout>
    )
}

export default App;
