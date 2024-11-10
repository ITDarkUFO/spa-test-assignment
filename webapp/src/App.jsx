import { React, useState, useEffect } from 'react';
import { Layout, Typography } from 'antd';

import { DataFetchProvider } from './context/DataFetchContext';
import { ModalProvider } from './context/ModalContext';

import PageContent from './components/PageContent';
import CreateProductModal from './components/CreateProductModal';
import ViewEditProductModal from './components/ViewEditProductModal';

import './App.css'

const { Header, Content, Footer } = Layout;
const { Title } = Typography;

function App() {
    const [pageHeight, setPageHeight] = useState(window.innerHeight);
    const [pageWidth, setPageWidth] = useState(window.innerWidth);

    useEffect(() => {
        const handleResize = () => {
            setPageWidth(window.innerWidth);
            setPageHeight(window.innerHeight);
        };
;
        window.addEventListener("resize", handleResize);

        return () => {
            window.removeEventListener("resize", handleResize);
        };

    }, []);

    return (
        <Layout style={{ minHeight: pageHeight }}>
            <Header>
                <Title style={{ color: "white" }}>SPA Shop</Title>
            </Header>
            <Content className="content-wrapper">
                <DataFetchProvider>
                    <ModalProvider>
                        <PageContent pageWidth={pageWidth} />
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
