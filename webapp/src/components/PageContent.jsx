import { useState, useEffect } from 'react';
import { Pagination, Typography, Row, Flex } from 'antd';

import { useDataFetch } from '../context/DataFetchContext';

import LoadingSkeleton from './LoadingSkeleton';
import CreateProductButton from './CreateProductButton';
import CardsList from './CardsList';

import axios from '../api/axios'

const { Title, Paragraph, Text } = Typography;

const PageContent = () => {
    const [page, setPage] = useState(1);
    const [pageSize, setPageSize] = useState(10);
    const [productsCount, setProductsCount] = useState(null);

    const [data, setData] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    const { state, dispatch } = useDataFetch();

    useEffect(() => {
        if (state.isDataFetchActive) {
            fetchDataAsync();
            dispatch({ type: 'TOGGLE_FETCH' });
        }
    }, [state.isDataFetchActive, dispatch]);

    const fetchDataAsync = async () => {
        try {
            setLoading(true);
            setError(null);

            const response = await axios.get(`/api/products`, {
                params: {
                    "page": page,
                    "pageSize": pageSize
                },
            });
            console.debug(response);

            setData(response.data.products);
            setProductsCount(response.data.productsCount);
        }
        catch (error) {
            console.error(error);

            switch (error.code) {
                case "ERR_NETWORK":
                    setError("Не удалось подключиться к серверу");
                    break;
                default:
                    setError(error.message);
            }
        }
        finally {
            setLoading(false);
        }
    }

    const onShowChange = (page, pageSize) => {
        setPage(page);
        setPageSize(pageSize);
        dispatch({ type: 'TOGGLE_FETCH' });
    };

    const ProductsPage = () => {
        if (productsCount === 0)
            return (<Text style={{ fontSize: 18 }}>Товаров нет</Text>);

        return (<CardsList productsData={data} onDelete={setData} />);
    };

    if (loading) return <LoadingSkeleton />;

    if (error) {
        return (
            <Flex vertical justify="center" align="center">
                <Title>Возникла ошибка при загрузке товаров</Title>
                <Paragraph>{error}</Paragraph>
            </Flex>
        );
    }

    return (
        <>
            <Flex justify="space-between">
                <Title>Список товаров</Title>
                <CreateProductButton />
            </Flex>
            <ProductsPage />
            <Pagination
                align="center"
                showSizeChanger
                onChange={onShowChange}
                current={page}
                pageSize={pageSize}
                total={productsCount}
            />
        </>
    )
}

export default PageContent;